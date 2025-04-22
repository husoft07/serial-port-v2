using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Cmd
{
    private SerialPort serialPort;
    private ListBox commandListBox; // command_lbox
    private TextBox outputBox;      // clitbox
    private string detectedEndLine;
    private bool isLoggedIn = false; // örnek login kontrolü (varsa)

    public Cmd(SerialPort port, ListBox cmdList, TextBox outputBox, string endLine)
    {
        this.serialPort = port;
        this.commandListBox = cmdList;
        this.outputBox = outputBox;
        this.detectedEndLine = endLine;
    }

    /// <summary>
    /// Komut satırını alır, '\' karakteri ile parçalar ve 
    /// yalnızca 1 adet birincil komut (runs, runb, repeat) ve 
    /// isteğe bağlı 1 adet wait komutunu işler.
    /// </summary>
    public async Task HandleAsync(string input)
    {
        // Örneğin giriş öncesi login kontrolü…
        if (!isLoggedIn)
        {
            // Eğer login gerekiyorsa, login işlemini burada gerçekleştirin.
            outputBox.AppendText("[Giriş yapılmadı. Lütfen >>login komutunu kullanın.]\n");
            return;
        }

        // '\' ile ayırıyoruz.
        string[] parts = input.Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
        bool primaryFound = false;
        bool waitFound = false;
        int waitTime = 0;

        // Önce birincil komut olup olmadığını kontrol edip çalıştırıyoruz.
        foreach (string part in parts)
        {
            string trimmed = part.Trim();
            if (!primaryFound &&
               (trimmed.StartsWith("runs", StringComparison.OrdinalIgnoreCase) ||
                trimmed.StartsWith("runb", StringComparison.OrdinalIgnoreCase) ||
                trimmed.StartsWith("repeat", StringComparison.OrdinalIgnoreCase)||
                trimmed.StartsWith("status", StringComparison.OrdinalIgnoreCase)||
                trimmed.StartsWith("logout", StringComparison.OrdinalIgnoreCase)))
            {
                primaryFound = true;
                if (trimmed.StartsWith("runs", StringComparison.OrdinalIgnoreCase))
                {
                    await HandleRunsCommandAsync(trimmed);
                }
                else if (trimmed.StartsWith("status", StringComparison.OrdinalIgnoreCase))
                {
                    outputBox.AppendText(StatusMessage + "\n");
                }
                else if (trimmed.StartsWith("logout", StringComparison.OrdinalIgnoreCase))
                {
                    Logout();
                    outputBox.AppendText("[Çıkış yapıldı.]\n");
                }
                else if (trimmed.StartsWith("runb", StringComparison.OrdinalIgnoreCase))
                {
                    await HandleRunbCommandAsync(trimmed);
                }
                else if (trimmed.StartsWith("repeat", StringComparison.OrdinalIgnoreCase))
                {
                    await HandleRepeatCommandAsync(trimmed);
                }
            }
            else if (!waitFound && trimmed.StartsWith("wait", StringComparison.OrdinalIgnoreCase))
            {
                waitFound = true;
                waitTime = ParseWaitTime(trimmed);
            }
            else
            {
                outputBox.AppendText($"[Bilinmeyen veya fazladan komut: {trimmed}]\n");
            }
        }

        if (primaryFound && waitFound && waitTime > 0)
        {
            // Primary komuttan sonra wait varsa, bekleme süresini uygula.
            await Task.Delay(waitTime);
        }
    }

    public bool IsLoggedIn => isLoggedIn;

    public void Login()
    {
        isLoggedIn = true;
    }

    public void Logout()
    {
        isLoggedIn = false;
    }

    public string StatusMessage => isLoggedIn ? "[Giriş yapılmış.]" : "[Giriş yapılmamış.]";


    private int ParseWaitTime(string waitCmd)
    {
        // wait komutu örn: "wait 1000" şeklinde olmalı.
        string[] parts = waitCmd.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length >= 2 && int.TryParse(parts[1], out int ms))
        {
            return ms;
        }
        return 0;
    }

    private async Task HandleRunsCommandAsync(string cmd)
    {
        // Örnek format: runs 1,3,5
        string param = cmd.Substring(4).Trim(); // "1,3,5"
        var indices = param.Split(',')
                           .Select(s => int.TryParse(s.Trim(), out int idx) ? idx - 1 : -1)
                           .Where(i => i >= 0 && i < commandListBox.Items.Count)
                           .ToList();

        foreach (int i in indices)
        {
            string commandText = commandListBox.Items[i].ToString();
            serialPort.Write(commandText + detectedEndLine);
            // Opsiyonel: kısa bir bekleme eklenebilir, istersen await Task.Delay(100);
            await Task.Delay(50);
        }
    }

    private async Task HandleRunbCommandAsync(string cmd)
    {
        // Örnek format: runb 3-7
        string param = cmd.Substring(4).Trim(); // "3-7"
        var range = param.Split('-');
        if (range.Length == 2 &&
            int.TryParse(range[0].Trim(), out int start) &&
            int.TryParse(range[1].Trim(), out int end))
        {
            // 1-index'ten 0-index'e çevirme
            start = Math.Max(0, start - 1);
            end = Math.Min(commandListBox.Items.Count - 1, end - 1);
            for (int i = start; i <= end; i++)
            {
                string commandText = commandListBox.Items[i].ToString();
                serialPort.Write(commandText + detectedEndLine);
                await Task.Delay(50);
            }
        }
        else
        {
            outputBox.AppendText("[runb: Geçersiz parametre aralığı]\n");
        }
    }

    private async Task HandleRepeatCommandAsync(string cmd)
    {
        // Örnek format: repeat 2-5,3 → 2-5 arası komutları 3 defa gönder
        string param = cmd.Substring(6).Trim(); // "2-5,3"
        var parts = param.Split(',');
        if (parts.Length != 2)
        {
            outputBox.AppendText("[repeat: Geçersiz format. Örnek: repeat 2-5,3]\n");
            return;
        }
        var range = parts[0].Split('-');
        if (range.Length != 2 ||
            !int.TryParse(range[0].Trim(), out int start) ||
            !int.TryParse(range[1].Trim(), out int end) ||
            !int.TryParse(parts[1].Trim(), out int repeatCount))
        {
            outputBox.AppendText("[repeat: Parametreler çözülemedi. Kontrol ediniz.]\n");
            return;
        }
        // 1-index'ten 0-index'e çevirme
        start = Math.Max(0, start - 1);
        end = Math.Min(commandListBox.Items.Count - 1, end - 1);

        for (int rep = 0; rep < repeatCount; rep++)
        {
            for (int i = start; i <= end; i++)
            {
                string commandText = commandListBox.Items[i].ToString();
                serialPort.Write(commandText + detectedEndLine);
                await Task.Delay(50);
            }
        }
    }
}
