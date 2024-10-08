using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Serial_Port
{
    public partial class Main_Form1 : Form
    {
        public Main_Form1()
        {
            InitializeComponent();
            dpi();
            System.Threading.Thread.CurrentThread.CurrentCulture =
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Lang);
            langset();
            LoadLanguages();
            getportlist();
            componentload();
            LoadfilepathItems();
            LoadDataControls();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadLanguages()
        {
            ResourceManager rm = new ResourceManager("Serial_Port.Properties.Strings", typeof(Main_Form1).Assembly);

            // Kültürleri listeleyin
            List<string> cultures = new List<string>();
            foreach (CultureInfo culture in CultureInfo.GetCultures(CultureTypes.AllCultures))
            {
                try
                {
                    ResourceSet rs = rm.GetResourceSet(culture, true, false);
                    if (rs != null)
                    {
                        cultures.Add(culture.Name);
                    }
                }
                catch (CultureNotFoundException)
                {
                    // Kültür bulunamadığında hata yakalayın
                }
            }

            // ComboBox'a ekleyin
            langs_tstrip_cb1.Items.AddRange(cultures.ToArray());
        }

        
        private void langset()
        {
            lang_tstripmenu1.Text = Properties.Strings.lang;
            connectset_tsmn.Text = Properties.Strings.connect_setting;
            help_tsmn.Text = Properties.Strings.help;
            appdetail_tsmn.Text = Properties.Strings.appdetail;
            about_tsmn.Text = Properties.Strings.about;
            portlist_tslabel.Text = Properties.Strings.portlist;
            connection_tsbtn.Text = Properties.Strings.connect;
            defines_tab.Text = Properties.Strings.defines;
            precommand_tab.Text = Properties.Strings.preconfig;
            refreshfile_btn.Text = Properties.Strings.refresh_filelist;
            sysIP.Text = Properties.Strings.sys_ip;
            getwayIP.Text = Properties.Strings.getwayIP;
            getsyslist_btn.Text = Properties.Strings.get_syslist;
            IPsfound_lb.Text = Properties.Strings.IPs_found;
            sysfound_lb.Text = Properties.Strings.sysfound;
            Device_lb.Text = Properties.Strings.devices;
            define_gb.Text = Properties.Strings.defines;
            startcfg_btn.Text = Properties.Strings.start_cfg;
            command_procces.Text = Properties.Strings.autocfg_proccess;
            saveascmd_cmts.Text = Properties.Strings.saveas;
            savecmd_cmts.Text = Properties.Strings.save;
            autocfg_cmts.Text = Properties.Strings.start_cfg;
            startselectedrown_cmstrip.Text = Properties.Strings.select_row;
            Edit_command_cmts.Text = Properties.Strings.edit;
            insertcmd_cmts.Text = Properties.Strings.insert_cmd_endlist;
            insert_between_cmd_cmts.Text = Properties.Strings.insert_between_cmd;
            Replace_selected_row_cmts.Text = Properties.Strings.replace_line;
            movedown_cmts.Text = Properties.Strings.move_down;
            moveup_cmts.Text = Properties.Strings.Move_up;
            save_cmd_cb_cmts.Text = Properties.Strings.save;
            replace_cmd_cb_cmts.Text = Properties.Strings.replace_line;
            insert_selectedrow_cmd_cb_cmts.Text = Properties.Strings.insert_between_cmd;
            insert_endline_cmd_cb_cmts.Text = Properties.Strings.insert_cmd_endlist;
            templates_tsmn.Text = Properties.Strings.templates;
            template_sample_tsmn.Text = Properties.Strings.templates_command;
            define_template_tsmn.Text = Properties.Strings.templates_definition;
            syslist_template_tsmn.Text = Properties.Strings.templates_syslist;

        }


        public void getconfig()
        {
            if (FilePathBox.Text.Length == 0)
            {
                MessageBox.Show(Properties.Strings.invalid_file_path);
            }
            else
            {
                string yol = FilePathBox.Text;
                command_lbox.Items.Clear();
                using (StreamReader oku = new StreamReader(yol))
                {
                    string satir = oku.ReadLine();
                    while (satir != null)
                    {
                        command_lbox.Items.Add(satir);
                        satir = oku.ReadLine();
                    }
                }
                // Dosyayı okuduktan sonra kapat
                // StreamReader otomatik olarak kapanacaktır.
            }
        }


        private void componentload()
        {
            try
            {
                foreach (var value in Enum.GetValues(typeof(Parity))) { parity_tscb.Items.Add(value); }
                parity_tscb.SelectedIndex = 0;
                baudrate_tscb.Items.AddRange(new object[] { 4800, 9600, 19200, 38400 }); baudrate_tscb.SelectedIndex = 1;
                databit_tscb.Items.AddRange(new object[] { 5, 6, 7, 8 }); databit_tscb.SelectedIndex = 3;
                stopbit_tscb.Items.AddRange(new object[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }); stopbit_tscb.SelectedIndex = 1;
                dtr_tscb.Items.AddRange(new object[] { true, false }); dtr_tscb.SelectedIndex = 0;
                serialPort1.DtrEnable = Convert.ToBoolean(dtr_tscb.SelectedItem);
                connection_tsbtn.BackColor = Color.LightGreen;
                getway_set.SelectedIndex = 5;
                Endline_cb.SelectedIndex = 3;

            }
            catch
            {

            }
        }

        public void openport()
        {
            try
            {
                serialPort1.PortName = portlist_tscb.SelectedItem.ToString();
                serialPort1.BaudRate = int.Parse(baudrate_tscb.SelectedItem.ToString());
                serialPort1.DataBits = int.Parse(databit_tscb.SelectedItem.ToString());
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), parity_tscb.SelectedItem.ToString());
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopbit_tscb.SelectedItem.ToString());

                try
                {
                    serialPort1.Open();
                    connection_tsbtn.Text = Properties.Strings.disconnect;
                    connection_tsbtn.BackColor = Color.IndianRed;
                    //MessageBox.Show("Seri port bağlantısı açıldı!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Properties.Strings.connected_mbox_error + " :" + ex.Message);
                }
            }
            catch { MessageBox.Show(Properties.Strings.connect_setting_error); }


        }
        private void getportlist()
        {
            try
            {

                portlist_tscb.Items.Clear();
                string[] ports = SerialPort.GetPortNames();
                foreach (string port in ports)
                {

                    portlist_tscb.Items.Add(port);

                }

                portlist_tscb.SelectedIndex = 0;
            }
            catch (Exception ex)
            { MessageBox.Show(Properties.Strings.port_error + " " + ex); }
        }

        public void dpi()
        {

            float dx, dy;

            Graphics g = this.CreateGraphics();
            try
            {
                dx = g.DpiX;
                dy = g.DpiY;
            }
            finally
            {
                g.Dispose();
                //float scaleFactor = dx / 96.0f; // 96 DPI varsayılan değeridir
                // System.Web.UI.Control.Width = (int)(originalWidth * ScaleFactor);
                //control.Height = (int)(originalHeight * scaleFactor);
            }
        }




        private void langs_tstrip_cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Lang = langs_tstrip_cb1.SelectedItem.ToString();
            Properties.Settings.Default.Save();
            Application.Restart();
        }

        private void connection_tsbtn_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                connection_tsbtn.Text = Properties.Strings.connect;
                connection_tsbtn.BackColor = Color.LightGreen;
                portlist_tscb.Items.Clear();
                getportlist();
            }
            else { openport(); }
        }

        private string DetectEndline(string response)
        {
            if (response.EndsWith("\r\n")) return "\r\n";
            if (response.EndsWith("\n")) return "\n";
            if (response.EndsWith("\r")) return "\r";
            return null; // Tespit edilemedi
        }

        private string detectedEndline=null;
        private void clitbox_KeyDown(object sender, KeyEventArgs e)
        {
           
                if (e.KeyCode == Keys.Enter)
                {
                    if (serialPort1.IsOpen)
                    {
                        // Komut sonu endline karakteri eklenmez, sadece komut gönderilir
                        string command = clitbox.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Last();
                        serialPort1.Write(command); // WriteLine yerine Write kullanılıyor
                        clitbox.AppendText(">> " + command + Environment.NewLine);
                        clitbox.SelectionStart = clitbox.Text.Length;
                        clitbox.ScrollToCaret();
                    }
                    else
                    {
                        MessageBox.Show("Seri port açık değil.");
                    }
                    e.SuppressKeyPress = true; // Enter tuşunun TextBox'a yeni satır eklemesini engelle
                }
           

            if (e.KeyCode == Keys.F2) { cmd_cb.Text = cmd_cb.Text + clitbox.SelectedText; cmd_cb.Focus(); cmd_cb.SelectionStart = cmd_cb.Text.Length; cmd_cb.SelectionLength = 0; }
            if (e.KeyCode == Keys.F12) { saveascommand(); }
        }

        private void writeIncomingData(string text) //Seri porttan gelen verileri okuyup anlık yazdırır
        {
            BeginInvoke(new EventHandler(delegate
            {

                clitbox.AppendText(text);
                clitbox.ScrollToCaret();
            }));
        }

        private StringBuilder receivedData = new StringBuilder();



        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //string incomingText = serialPort1.ReadExisting();
            //writeIncomingData(incomingText);
            // Gelen veriyi oku ve biriktir
            string data = serialPort1.ReadExisting();
            receivedData.Append(data);

            // Eğer satır sonu karakteri henüz tespit edilmediyse
            if (detectedEndline == null)
            {
                detectedEndline = DetectEndline(receivedData.ToString());
            }

            // Satır sonu karakteri tespit edilmişse, gelen veriyi bu karaktere göre işleme
            if (!string.IsNullOrEmpty(detectedEndline))
            {
                string[] lines = receivedData.ToString().Split(new string[] { detectedEndline }, StringSplitOptions.None);

                // İşlenen satırları ekrana yaz ve birikenden çıkar
                for (int i = 0; i < lines.Length - 1; i++)
                {
                    Invoke(new Action(() => clitbox.AppendText(lines[i] + Environment.NewLine)));
                }

                // Son işlenmeyen satırı saklamak için receivedData'yı güncelle
                receivedData.Clear();
                receivedData.Append(lines[lines.Length - 1]);
            }
            else
            {
                // Satır sonu karakteri tespit edilene kadar gelen veriyi ekle
                Invoke(new Action(() => clitbox.AppendText(data)));
            }
        }

        private void portlist_tslabel_Click(object sender, EventArgs e)
        {
            getportlist();
        }

        private void command_lbox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void command_lbox_DragEnter(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            command_lbox.Items.Clear(); // Listbox taki eski veriyi temizler
            foreach (string file in files)
            {
                if (Path.GetExtension(file) == ".txt")
                {
                    string[] lines = File.ReadAllLines(file);
                    foreach (string line in lines)
                    {
                        command_lbox.Items.Add(line);

                    }
                    FilePathBox.Items.Add(file);
                    FilePathBox.SelectedIndex = FilePathBox.Items.Count - 1;
                }
            }
        }

        private void FilePathBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            getconfig();
        }

        private void configlist()
        {
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "config"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "config");
            }
            FilePathBox.Text = "";
            FilePathBox.Items.Clear();
            string[] dosyalar = Directory.GetFiles("config");
            foreach (string dosya in dosyalar)
            {
                if (dosya.EndsWith(".txt") || dosya.EndsWith(".ini"))
                    FilePathBox.Items.Add(dosya);
            }

        }

        private string configFilePath = Path.Combine(Application.StartupPath, "config", "filelist.txt");

        private void LoadfilepathItems()
        {
            if (File.Exists(configFilePath))
            {
                string[] lines = File.ReadAllLines(configFilePath);
                FilePathBox.Items.AddRange(lines);
            }
            else { configlist(); }
        }

        private void SavefilepathItems()
        {
            // Combobox içeriğini dosyaya kaydet
            using (StreamWriter writer = new StreamWriter(configFilePath))
            {
                foreach (var item in FilePathBox.Items)
                {
                    writer.WriteLine(item.ToString());
                }
            }
        }

        private void Main_Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SavefilepathItems();
        }

        private void saveascommand()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {

                try
                {
                    saveFileDialog.Filter = "Metin Dosyaları (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        // TextBox içeriğini dosyaya yazın
                        File.WriteAllText(filePath, clitbox.Text);

                        MessageBox.Show(Properties.Strings.save_ok, Properties.Strings.info, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch { }
            }
        }

        private void clitbox_DoubleClick(object sender, EventArgs e)
        {
            string a = clitbox.SelectedText.Trim();
            cmd_cb.Text = cmd_cb.Text + a + " ";
            cmd_cb.Focus();
            cmd_cb.SelectionStart = cmd_cb.Text.Length;
            cmd_cb.SelectionLength = 0;
        }

        private void inserttext()
        {
            try { command_lbox.Items.Insert(command_lbox.SelectedIndex, cmd_cb.Text); } catch (Exception) { MessageBox.Show("Hazır komut ekranında bir satır seçmelisiniz"); }
        }

        private void replacetext() { try { command_lbox.Items[command_lbox.SelectedIndex] = cmd_cb.Text; } catch (Exception) { MessageBox.Show("Hazır komut ekranında bir satır seçmelisiniz"); } }




        private void command_lbox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    string data = command_lbox.SelectedItem.ToString()
                        .Replace(sysip_lb.Text, sysip_cb.Text)
                        .Replace(routeip_lb.Text, routip_cb.Text)
                        .Replace(val1_lb.Text, val1_cb.Text)
                        .Replace(val2_lb.Text, val2_cb.Text)
                        .Replace(val3_lb.Text, val3_cb.Text)
                        .Replace(val4_lb.Text, val4_cb.Text)
                        .Replace(val5_lb.Text, val5_cb.Text)
                        .Replace(val6_lb.Text, val6_cb.Text)
                        .Replace(val7_lb.Text, val7_cb.Text)
                        .Replace(val8_lb.Text, val8_cb.Text);

                    switch (Endline_cb.SelectedIndex)
                    {

                        case 0:
                            serialPort1.Write(data);
                            break;
                        case 1:
                            serialPort1.Write(data + "\r");
                            break;
                        case 2:
                            serialPort1.Write(data + "\n");
                            break;
                        case 3:
                            serialPort1.Write(data + "\r\n");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show(Properties.Strings.port_closed);
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(Properties.Strings.connect_errormsg + ": " + exe.Message, Properties.Strings.device_connect_errormsg, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void baudrate_tscb_SelectedIndexChanged(object sender, EventArgs e)
        {
            baudrateToolStripMenuItem.Text = "Baudrate --> " + baudrate_tscb.Text;
        }

        private void databit_tscb_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataBitToolStripMenuItem.Text = "Data Bit --> " + databit_tscb.Text;
        }

        private void parity_tscb_SelectedIndexChanged(object sender, EventArgs e)
        {
            parityToolStripMenuItem.Text = "Parity --> " + parity_tscb.Text;
        }

        private void stopbit_tscb_SelectedIndexChanged(object sender, EventArgs e)
        {
            stopBitToolStripMenuItem.Text = "Stop Bit --> " + stopbit_tscb.Text;
        }

        private void dtr_tscb_SelectedIndexChanged(object sender, EventArgs e)
        {
            dTREnableToolStripMenuItem.Text = "DTREnable --> " + dtr_tscb.Text;
        }

        private void portlist_tscb_SelectedIndexChanged(object sender, EventArgs e)
        {
            portToolStripMenuItem.Text = "Port --> " + portlist_tscb.Text;
        }

        public void otosend()
        {
            try
            {
                int itemCount = command_lbox.Items.Count;
                int progressStep = 100 / itemCount;
                //int selectedIndex = checkBox2.Checked ? CommandLBox.SelectedIndex : 4;
                int selectedIndex = command_lbox.SelectedIndex = 4;

                if (serialPort1.IsOpen)
                {
                    for (int i = 3; i < itemCount; i++)
                    {
                        string data = command_lbox.Items[i].ToString()
                            .Replace(sysip_lb.Text, sysip_cb.Text)
                            .Replace(routeip_lb.Text, routip_cb.Text)
                            .Replace(val1_lb.Text, val1_cb.Text)
                            .Replace(val2_lb.Text, val2_cb.Text)
                            .Replace(val3_lb.Text, val3_cb.Text)
                            .Replace(val4_lb.Text, val4_cb.Text)
                            .Replace(val5_lb.Text, val5_cb.Text)
                            .Replace(val6_lb.Text, val6_cb.Text)
                            .Replace(val7_lb.Text, val7_cb.Text)
                            .Replace(val8_lb.Text, val8_cb.Text);

                        Autocfg_procces.Value = i * progressStep;
                        string command = data.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Last();
                        serialPort1.Write(data);

                        if (!string.IsNullOrEmpty(selectedEndline))
                        {
                            serialPort1.Write(selectedEndline); // Satır sonu karakterini gönder
                        }

                        if (i == itemCount - 1)
                        {
                            Autocfg_procces.Value = 100;
                            MessageBox.Show(Properties.Strings.Complate);
                        }
                    }
                    
                }
            
                
                else
                {
                    MessageBox.Show(Properties.Strings.port_error);
                }
            }
            catch (Exception)
            
                // if (checkBox2.Checked) MessageBox.Show("Bir satır seçmelisiniz");
                { MessageBox.Show(Properties.Strings.unknown_connect_error); }
        }        


        public void otosend_selectedrow()
        {
            try
            {
                int itemCount = command_lbox.Items.Count;
                int progressStep = 100 / itemCount;
                //int selectedIndex = checkBox2.Checked ? CommandLBox.SelectedIndex : 4;
                

                if (serialPort1.IsOpen)
                {
                    if (command_lbox.SelectedIndex == -1)
                    { MessageBox.Show("başlamak için bir satır seçin"); }
                    else {
                        for (int i = command_lbox.SelectedIndex; i < itemCount; i++)
                        {
                            string data = command_lbox.Items[i].ToString()
                                .Replace(sysip_lb.Text, sysip_cb.Text)
                                .Replace(routeip_lb.Text, routip_cb.Text)
                                .Replace(val1_lb.Text, val1_cb.Text)
                                .Replace(val2_lb.Text, val2_cb.Text)
                                .Replace(val3_lb.Text, val3_cb.Text)
                                .Replace(val4_lb.Text, val4_cb.Text)
                                .Replace(val5_lb.Text, val5_cb.Text)
                                .Replace(val6_lb.Text, val6_cb.Text)
                                .Replace(val7_lb.Text, val7_cb.Text)
                                .Replace(val8_lb.Text, val8_cb.Text);

                            Autocfg_procces.Value = i * progressStep;
                            string command = data.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Last();
                            serialPort1.Write(data);

                            if (!string.IsNullOrEmpty(selectedEndline))
                            {
                                serialPort1.Write(selectedEndline); // Satır sonu karakterini gönder
                            }

                            if (i == itemCount - 1)
                            {
                                Autocfg_procces.Value = 100;
                                MessageBox.Show(Properties.Strings.Complate);
                            }
                        }
                    }

                }


                else
                {
                    MessageBox.Show(Properties.Strings.port_error);
                }
            }
            catch (Exception)

            // if (checkBox2.Checked) MessageBox.Show("Bir satır seçmelisiniz");
            { MessageBox.Show(Properties.Strings.unknown_connect_error); }
        }


        private void autocfg_cmts_Click(object sender, EventArgs e)
        {
            otosend();
        }

        private void startselectedrown_cmstrip_Click(object sender, EventArgs e)
        {
            otosend_selectedrow();
        }

        private void startcfg_btn_Click(object sender, EventArgs e)
        {
            otosend();
        }



        private void refreshfile_btn_Click(object sender, EventArgs e)
        {
            configlist();

        }

        public void sysnamelist()
        {
            sysfound_cb.Items.Clear();
            string a = "";
            string sys_name = syslist_cb.Text;
            int startIndex = sys_name.IndexOf("(");
            int endIndex = sys_name.IndexOf(")");
            if (startIndex >= 0 && endIndex > startIndex)
            {
                string extractedText = sys_name.Substring(startIndex + 1, endIndex - startIndex - 1);
                // Ayıklanan metni Label kontrolüne atayın
                a = extractedText;
            }
            else
            {
                // Parantez içinde veri yoksa veya hatalı bir seçim yapıldıysa bir hata mesajı gösterin
                a = "Sistem ismi bulunamadı!";
            }
            char delimiter = '|';

            // Metni belirtilen ayırıcı karakterle böler
            string[] parts = a.Split(delimiter);

            // Her bir bölümü ComboBox öğesinin öğe listesine ekler
            foreach (string part in parts)
            {
                sysfound_cb.Items.Add(part);
            }
            sysfound_cb.SelectedIndex = 0;
        }

        public void ipinfo()
        {
            try
            {
                syslist_cb.Items.AddRange(File.ReadAllLines(@"defines\syslist.txt"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Uygulama dizini\\defines içerisinde ipinfo.txt dosyası yoksa kendi liste dosyanızı sürükleyip bırakabilirsiniz.", "Dosya Bulunamadı: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getsyslist_btn_Click(object sender, EventArgs e)
        {
            ipinfo();
        }

        private void iplist()
        {
            IPsfound_cb.Items.Clear();
            string a = "";
            string sys_ip = syslist_cb.Text;
            int startIndex = sys_ip.IndexOf("[");
            int endIndex = sys_ip.IndexOf("]");
            if (startIndex >= 0 && endIndex > startIndex)
            {
                string extractedText = sys_ip.Substring(startIndex + 1, endIndex - startIndex - 1);
                // Ayıklanan metni Label kontrolüne atayın
                a = extractedText;

            }
            else
            {
                // Parantez içinde veri yoksa veya hatalı bir seçim yapıldıysa bir hata mesajı gösterin
                a = "Sistem IP bulunamadı!";
            }
            char delimiter = '|';

            // Metni belirtilen ayırıcı karakterle böler
            string[] parts = a.Split(delimiter);

            // Her bir bölümü ComboBox öğesinin öğe listesine ekler
            foreach (string part in parts)
            {
                IPsfound_cb.Items.Add(part);
            }
            IPsfound_cb.SelectedIndex = 0;
        }

        private void find()
        {
            sysip_cb.Text = string.Empty;
            string searchText = syslist_cb.Text.ToLower();
            int index = -1;

            for (int i = 0; i < syslist_cb.Items.Count; i++)
            {
                string itemText = syslist_cb.GetItemText(syslist_cb.Items[i]).ToLower();
                if (itemText.Contains(searchText))
                {
                    index = i;
                    break;
                }

            }

            if (index != -1)
            {
                // Değer bulundu, ilgili indeksi seçin:
                syslist_cb.SelectedIndex = index;
                if (syslist_cb.Text.Contains("ALC")) { Devices_cb.SelectedIndex = 0; }
                if (syslist_cb.Text.Contains("HUA")) { Devices_cb.SelectedIndex = 1; }
                if (syslist_cb.Text.Contains("ZTE")) { Devices_cb.SelectedIndex = 2; }
                // else {  shelfbox.SelectedIndex = 3; }

            }
            else
            {
                // Değer bulunamadı, uyarı verin:
                MessageBox.Show("Aradığınız değer bulunamadı.");
            }

        }

        private void syslist_cb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                sysip_cb.Text = string.Empty;
                sysip_tslb.Text = Properties.Strings.sys_ip;
                find();
                sysnamelist();
                iplist();
                //comboBox3.Focus();

            }

            if (e.KeyCode == Keys.Up)
            {
                e.SuppressKeyPress = true;
                try
                {
                    syslist_cb.SelectedIndex = syslist_cb.SelectedIndex - 1;
                    syslist_cb.Focus();
                }

                catch (Exception)
                {
                    MessageBox.Show("İzin verilen aralığın dışındasınız.");
                    syslist_cb.SelectedIndex = 0;
                    syslist_cb.Focus();
                }

            }

            if (e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true;
                try
                {
                    syslist_cb.SelectedIndex = syslist_cb.SelectedIndex + 1;
                    syslist_cb.Focus();

                }
                catch (Exception)
                {
                    MessageBox.Show("İzin verilen aralığın dışındasınız.");
                    syslist_cb.SelectedIndex = syslist_cb.Items.Count - 1;
                    syslist_cb.Focus();
                }

            }
        }

        private void syslist_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            sysnamelist();
            iplist();
            //sysname_tslb.Text = Properties.Strings.sysname + "-->" + sysfound_cb.Text;
            //sysip_tslb.Text =Properties.Strings.sys_ip +"-->"+ IPsfound_cb.Text;
            if (syslist_cb.Text.Contains("ALC")) { Devices_cb.SelectedIndex = 0; }
            if (syslist_cb.Text.Contains("HUA")) { Devices_cb.SelectedIndex = 1; }
            if (syslist_cb.Text.Contains("ZTE")) { Devices_cb.SelectedIndex = 2; }
        }

        private void IPsfound_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sysfound_cb.SelectedIndex = IPsfound_cb.SelectedIndex;
                sysname_tslb.Text = Properties.Strings.sysname + " --> " + sysfound_cb.Text;
                sysip_tslb.Text = Properties.Strings.sys_ip + " --> " + IPsfound_cb.Text;
                sysIP_tb.Text = IPsfound_cb.Text;
                getwayblock();
            }
            catch { }
        }

        private void sysfound_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                IPsfound_cb.SelectedIndex = sysfound_cb.SelectedIndex;
                sysname_tslb.Text = Properties.Strings.sysname + " --> " + sysfound_cb.Text;
                sysip_tslb.Text = Properties.Strings.sys_ip + " --> " + IPsfound_cb.Text;

            }
            catch { }
        }

        private void Devices_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = "";
            string sys_name = Devices_cb.Text;
            int startIndex = sys_name.IndexOf("(");
            int endIndex = sys_name.IndexOf(")");
            if (startIndex >= 0 && endIndex > startIndex)
            {
                string extractedText = sys_name.Substring(startIndex + 1, endIndex - startIndex - 1);
                // Ayıklanan metni Label kontrolüne atayın
                a = extractedText;
                if (a.Contains("r")) { Endline_cb.SelectedIndex = 1; }
                if (a.Contains("n")) { Endline_cb.SelectedIndex = 2; }
                if (a.Contains("rn")) { Endline_cb.SelectedIndex = 3; }
            }
            else
            {
                // Parantez içinde veri yoksa veya hatalı bir seçim yapıldıysa bir hata mesajı gösterin
                Endline_cb.SelectedIndex = 0;
            }
        }

        private void getway_set_SelectedItemChanged(object sender, EventArgs e)
        {
            getwayblock();
        }

        private void getwayblock()
        {
            string ipAddress = sysIP_tb.Text;

            // IP adresini '.' veya ':' karakterine göre böl
            char[] separators = new char[] { '.', ':' };
            string[] ipBlocks = ipAddress.Split(separators);

            // Kullanılan ayırıcıyı belirle
            char usedSeparator = ipAddress.Contains('.') ? '.' : ':';

            // ComboBox'tan seçilen blok sayısını al
            int selectedBlocks = int.Parse(getway_set.Text);

            // Seçilen blok sayısına göre IP adresini oluştur ve textBox2'ye yaz
            if (ipBlocks.Length >= selectedBlocks)
            {
                GetwayIP_tb.Text = string.Join(usedSeparator.ToString(), ipBlocks.Take(selectedBlocks));
                routip_cb.Text = GetwayIP_tb.Text.Trim();
            }
        }



        private void sysIP_tb_TextChanged(object sender, EventArgs e)
        {
            getwayblock();
            sysip_cb.Text = sysIP_tb.Text.Trim();
            ipcheck();

        }

        private void sysIP_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') &&
     (e.KeyChar != 'a') && (e.KeyChar != 'b') && (e.KeyChar != 'c') &&
     (e.KeyChar != 'd') && (e.KeyChar != 'e') && (e.KeyChar != 'f') &&
     (e.KeyChar != ':'))
            {
                e.Handled = true;
            }

        }

        private bool IsValidIPAddress(string ipAddress)
        {
            //return System.Net.IPAddress.TryParse(ipAddress, out _);
            if (IPAddress.TryParse(ipAddress, out _))
            {
                // IPv4 kontrolü
                string ipv4Pattern = @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\." +
                                     @"(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\." +
                                     @"(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\." +
                                     @"(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";

                // IPv6 kontrolü
                string ipv6Pattern = @"^([0-9a-fA-F]{1,4}:){7}([0-9a-fA-F]{1,4}|:)$";

                if (Regex.IsMatch(ipAddress, ipv4Pattern) || Regex.IsMatch(ipAddress, ipv6Pattern))
                {
                    return true;
                }
            }
            return false;
        }


        private void ipcheck()
        {
            string ipAddress = sysIP_tb.Text;
            if (IsValidIPAddress(ipAddress))
            {
                sysip_tslb.Text = Properties.Strings.sys_ip + "  -->  " + sysIP_tb.Text;
                sysip_tslb.ForeColor = Color.Black;
            }
            else
            {
                sysip_tslb.Text = Properties.Strings.sys_ip + "  -->  " + sysIP_tb.Text + "  -->  " + Properties.Strings.ip_error;
                sysip_tslb.ForeColor = Color.Red;
            }
        }

        private void command_lbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9) { inserttext(); }
            if (e.KeyCode == Keys.F10) { replacetext(); }
            if (e.KeyCode == Keys.F11) { command_lbox.Items.Add(cmd_cb.Text); }
            if (e.KeyCode == Keys.F5) { getconfig(); }
            if (e.KeyCode == Keys.F2)
            {
                int i = command_lbox.SelectedIndex;
                string data = command_lbox.Items[i].ToString()
                            .Replace(sysip_lb.Text, sysip_cb.Text)
                            .Replace(routeip_lb.Text, routip_cb.Text)
                            .Replace(val1_lb.Text, val1_cb.Text)
                            .Replace(val2_lb.Text, val2_cb.Text)
                            .Replace(val3_lb.Text, val3_cb.Text)
                            .Replace(val4_lb.Text, val4_cb.Text)
                            .Replace(val5_lb.Text, val5_cb.Text)
                            .Replace(val6_lb.Text, val6_cb.Text)
                            .Replace(val7_lb.Text, val7_cb.Text)
                            .Replace(val8_lb.Text, val8_cb.Text);
                cmd_cb.Text = data; cmd_cb.Focus();
            }

            if (e.KeyCode == Keys.Delete)
            {
                try { command_lbox.Items.RemoveAt(command_lbox.SelectedIndex); }
                catch { MessageBox.Show(Properties.Strings.error_select_list); }
            }
        }

        private void Edit_command_cmts_Click(object sender, EventArgs e)
        {
            int i = command_lbox.SelectedIndex;
            string data = command_lbox.Items[i].ToString()
                        .Replace(sysip_lb.Text, sysip_cb.Text)
                        .Replace(routeip_lb.Text, routip_cb.Text)
                        .Replace(val1_lb.Text, val1_cb.Text)
                        .Replace(val2_lb.Text, val2_cb.Text)
                        .Replace(val3_lb.Text, val3_cb.Text)
                        .Replace(val4_lb.Text, val4_cb.Text)
                        .Replace(val5_lb.Text, val5_cb.Text)
                        .Replace(val6_lb.Text, val6_cb.Text)
                        .Replace(val7_lb.Text, val7_cb.Text)
                        .Replace(val8_lb.Text, val8_cb.Text);
            cmd_cb.Text = data; cmd_cb.Focus();
        }

        private void insertcmd_cmts_Click(object sender, EventArgs e)
        {
            command_lbox.Items.Add(cmd_cb.Text);
        }

        private void saveascmd_cmts_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = Properties.Strings.text_file + " (*.txt)|*.txt|" + Properties.Strings.all_file + "   (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Kullanıcının seçtiği dosyanın yolunu alın
                string filePath = saveFileDialog1.FileName;

                // ListBox içeriğini dosyaya yazın
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var item in command_lbox.Items)
                    {
                        writer.WriteLine(item.ToString());
                    }
                }

                // Başarılı bir şekilde kaydedildiğini bildiren bir iletişim kutusu gösterin
                MessageBox.Show(Properties.Strings.save_ok, Properties.Strings.info, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void savecmd_cmts_Click(object sender, EventArgs e)
        {
            string selectedFilePath = FilePathBox.Text;
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show(Properties.Strings.file_select_message, Properties.Strings.warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Dosya var mı kontrol edin
            if (File.Exists(selectedFilePath))
            {
                // Varolan dosya için onay isteyin
                DialogResult result = MessageBox.Show(Properties.Strings.warning_file, Properties.Strings.warning_file, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return; // Kullanıcı dosyayı üzerine yazmak istemiyorsa işlemi iptal edin
            }

            // ListBox içeriğini dosyaya yazın
            using (StreamWriter writer = new StreamWriter(selectedFilePath))
            {
                foreach (var item in command_lbox.Items)
                {
                    writer.WriteLine(item.ToString());
                }
            }

            // Başarılı bir şekilde kaydedildiğini bildiren bir iletişim kutusu gösterin
            MessageBox.Show(Properties.Strings.save_ok, Properties.Strings.info, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Replace_selected_row_cmts_Click(object sender, EventArgs e)
        {
            replacetext();
        }

        private void insert_between_cmd_cmts_Click(object sender, EventArgs e)
        {
            inserttext();
        }
        private void MoveItem(int direction)
        {
            // ListBox'ta seçili eleman yoksa veya ilk/son eleman seçiliyse çık
            if (command_lbox.SelectedItem == null || command_lbox.SelectedIndex < 0)
                return;

            // Yeni indeks
            int newIndex = command_lbox.SelectedIndex + direction;

            // Yeni indeks geçerli değilse çık
            if (newIndex < 0 || newIndex >= command_lbox.Items.Count)
                return;

            // Seçili elemanı al
            object selected = command_lbox.SelectedItem;

            // Elemanı eski yerinden kaldır
            command_lbox.Items.Remove(selected);

            // Elemanı yeni yerine ekle
            command_lbox.Items.Insert(newIndex, selected);

            // Yeni yeri seçili yap
            command_lbox.SetSelected(newIndex, true);
        }

        private void moveup_cmts_Click(object sender, EventArgs e)
        {
            MoveItem(-1);
        }

        private void movedown_cmts_Click(object sender, EventArgs e)
        {
            MoveItem(1);
        }

        // Global değişken tanımları
        private string selectedEndline = ""; // Varsayılan olarak boş, yani satır sonu yok

        private void cmd_cb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Enter tuşunun TextBox'a yeni satır eklemesini engelle
                if (serialPort1.IsOpen)
                {
                    // Komutu sonlandırmadan gönder, ardından seçilen endline karakterini gönder
                    string command = cmd_cb.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Last();
                    serialPort1.Write(command); // Komutu gönder
                    if (!string.IsNullOrEmpty(selectedEndline))
                    {
                        serialPort1.Write(selectedEndline); // Satır sonu karakterini gönder
                    }
                    cmd_cb.Text=string.Empty;
                }
                else
                {
                    MessageBox.Show("Seri port açık değil.");
                }
                
            }
            if (e.KeyCode == Keys.Up)
            {
                // Yukarı ok tuşuna basıldığında önceki değeri çağırın
                e.SuppressKeyPress = true;
                try
                {
                    if (cmd_cb.Items.Count > 0)
                    {
                        if (cmd_cb.SelectedIndex <= 0) { cmd_cb.SelectedIndex = cmd_cb.Items.Count - 1; }
                        else { cmd_cb.SelectedIndex = cmd_cb.SelectedIndex - 1; }
                    }
                }
                catch
                { }
            }
            if (e.KeyCode == Keys.Down)
            {
                // Aşağı ok tuşuna basıldığında sonraki değeri çağırın
                e.SuppressKeyPress = true;
                try
                {
                    if (cmd_cb.SelectedIndex == cmd_cb.Items.Count - 1) { cmd_cb.SelectedIndex = 0; }
                    else { cmd_cb.SelectedIndex = cmd_cb.SelectedIndex + 1; }
                }
                catch { }
            }


            if (serialPort1.IsOpen && (e.KeyCode == Keys.F1))
            {
                //e.SuppressKeyPress |= true;
                switch (Endline_cb.SelectedIndex)
                {
                    case 0:
                        serialPort1.Write(cmd_cb.Text + " ?");
                        break;
                    case 1:
                        serialPort1.Write(cmd_cb.Text + " ?" + "\r");
                        break;
                    case 2:
                        serialPort1.Write(cmd_cb.Text + " ?" + "\n");
                        break;
                    case 3:
                        serialPort1.Write(cmd_cb.Text + " ?" + "\r\n");
                        break;
                }

            }
        }

        private void save_cmd_cb_cmts_Click(object sender, EventArgs e)
        {


            saveFileDialog1.Filter = Properties.Strings.text_file + " (*.txt)|*.txt|" + Properties.Strings.all_file + " (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Kullanıcının seçtiği dosyanın yolunu alın
                string filePath = saveFileDialog1.FileName;

                // ListBox içeriğini dosyaya yazın
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var item in cmd_cb.Items)
                    {
                        writer.WriteLine(item.ToString());
                    }
                }

                // Başarılı bir şekilde kaydedildiğini bildiren bir iletişim kutusu gösterin
                MessageBox.Show(Properties.Strings.save_ok, Properties.Strings.info, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void insert_endline_cmd_cb_cmts_Click(object sender, EventArgs e)
        {
            command_lbox.Items.Add(cmd_cb.Text);
        }

        private void insert_selectedrow_cmd_cb_cmts_Click(object sender, EventArgs e)
        {
            inserttext();
        }

        private void replace_cmd_cb_cmts_Click(object sender, EventArgs e)
        {
            replacetext();
        }

        private void LoadDataControls()
        {
            try
            {
                var lines = File.ReadAllLines(@"defines\data.txt");
                foreach (var line in lines)
                {
                    for (int i = 1; i <= 8; i++)
                    {
                        string labelName = $"val{i}_lb";
                        string comboBoxName = $"val{i}_cb";

                        if (line.Contains(labelName))
                        {
                            var parts = line.Split(new[] { '=', '|' }, StringSplitOptions.RemoveEmptyEntries);
                            if (parts.Length == 4)
                            {
                                // labels[i-1].Text yerine labelName kullanarak ilgili label'ı bul
                                var label = this.Controls.Find(labelName, true).FirstOrDefault() as System.Windows.Forms.Label;
                                if (label != null)
                                {
                                    label.Text = parts[1].Trim();
                                }

                                var comboBoxValues = parts[2].Split('>')
                                                             .Select(v => v.Trim())
                                                             .ToArray();
                                var comboBox = this.Controls.Find(comboBoxName, true).FirstOrDefault() as System.Windows.Forms.ComboBox;
                                if (comboBox != null)
                                {
                                    comboBox.Items.AddRange(comboBoxValues);

                                    if (int.TryParse(parts[3].Trim(), out int selectedIndex) && selectedIndex >= 0 && selectedIndex < comboBox.Items.Count)
                                    {
                                        comboBox.SelectedIndex = selectedIndex;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch { }

        }

        private void syslist_template_tsmn_Click(object sender, EventArgs e)
        {
            defines.sample_syslist();
        }

        private void template_sample_tsmn_Click(object sender, EventArgs e)
        {
            
        }

        private void define_template_tsmn_Click(object sender, EventArgs e)
        {
            defines.sample_defines();
        }

        private void nokiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            defines.samplenokiacmd();  
        }

        private void zTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            defines.sampleztecmd();
        }

        private void huaweiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            defines.samplehuaweicmd();  
        }

        private void test1()
        {
            

        }

        private void Endline_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Endline_cb.SelectedItem.ToString())
            {
                case "\\r":
                    selectedEndline = "\r"; // \r karakterini ata
                    break;
                case "\\n":
                    selectedEndline = "\n"; // \n karakterini ata
                    break;
                case "\\r\\n":
                    selectedEndline = "\r\n"; // \r\n karakterini ata
                    break;
                case "null":
                    selectedEndline = ""; // \r\n karakterini ata
                    break;
            }
        }
    }
}
