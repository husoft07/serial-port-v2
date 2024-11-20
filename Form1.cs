using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Documents;
using System.Windows.Forms;
using samplecmd;

namespace Serial_Port
{
    public partial class Main_Form1 : Form
    {
        public Main_Form1()
        {
            InitializeComponent();
            Dpi();
            System.Threading.Thread.CurrentThread.CurrentCulture =
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Lang);
            langset();
            LoadLanguages();
            Getportlist();           
            Componentload();
            LoadfilepathItems();
            LoadDataControls();
            LoadCommandsFromFile("commands.txt");
            InitializeSuggestionBox();
            //Main_Form1 form=this;
            //LoadComboBoxIndexes(form);
            libraryload();
            
                
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void libraryload()
        {
            string startupPath = Application.StartupPath;
            string[] dllFiles = Directory.GetFiles(startupPath, "*.dll");

            foreach (var dllPath in dllFiles)
            {
                try
                {
                    Assembly dll = Assembly.LoadFrom(dllPath);
                    foreach (var type in dll.GetTypes())
                    {
                        if (type.Name == "MenuHelper")
                        {
                            var method = type.GetMethod("CreateSampleMenu");

                            if (method != null)
                            {
                                method.Invoke(null, new object[] { menuStrip1 });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"DLL yükleme hatası ({dllPath}): {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private List<string> commandList = new List<string>(); // Komut listesi
        private ListBox suggestionBox = new ListBox(); // Öneriler için ListBox

        private void LoadCommandsFromFile(string filePath)
        {
            try
            {
                commandList = File.ReadAllLines(filePath).ToList(); // Dosyadan komutları yükle
            }
            catch { }
            
        }

        private string ReplaceCommandData(string command)
        {
            return command
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
        }


        private void InitializeSuggestionBox()
        {
            suggestionBox.Visible = false;
            suggestionBox.Height = 100;
            suggestionBox.Width = 200;
            this.Controls.Add(suggestionBox); // Öneri kutusunu forma ekle

            // ComboBox'ta caret pozisyonunu izlemek için TextChanged olayını ekliyoruz
            cmd_cb.TextChanged += Cmd_cb_TextChanged;

            // suggestionBox öğeleri değiştikçe boyutu ayarlama
            suggestionBox.DataSourceChanged += SuggestionBox_DataSourceChanged;
            suggestionBox.MeasureItem += SuggestionBox_MeasureItem;
        }

        // Öneri kutusunun boyutunu güncelleyen olay
        private void SuggestionBox_DataSourceChanged(object sender, EventArgs e)
        {
            ResizeSuggestionBox();
        }

        // ListBox öğelerinin boyutunu hesapla
        private void ResizeSuggestionBox()
        {
            int maxWidth = suggestionBox.Width;  // Mevcut genişliği başlangıçta tut
            int totalHeight = 0;  // Toplam yükseklik

            using (Graphics g = suggestionBox.CreateGraphics())
            {
                foreach (var item in suggestionBox.Items)
                {
                    // Öğenin genişliğini ölç
                    SizeF size = g.MeasureString(item.ToString(), suggestionBox.Font);
                    maxWidth = Math.Max(maxWidth, (int)size.Width + SystemInformation.VerticalScrollBarWidth);  // Genişliği karşılaştır

                    // Toplam yükseklik
                    totalHeight += suggestionBox.ItemHeight;
                }
            }

            // Yeniden boyutlandırma
            suggestionBox.Width = maxWidth;
            suggestionBox.Height = Math.Min(totalHeight, 500); // Maksimum 200 yüksekliğinde tut
        }

        // Her öğe ölçüldüğünde çağrılır (gerektiğinde)
        private void SuggestionBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            // Varsayılan öğe yüksekliğini ayarlayabiliriz
            e.ItemHeight = suggestionBox.Font.Height;
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
            saveAsCLIPanelToolStripMenuItem.Text = Properties.Strings.cli_screen_save;
            sendCMDLineForEditToolStripMenuItem.Text = Properties.Strings.send_selected_cmd_line;
            copyToolStripMenuItem.Text = Properties.Strings.copy;
            pasteToolStripMenuItem.Text = Properties.Strings.paste;
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


        public void Getconfig()
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


        private void Componentload()
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
        private void Getportlist()
        {
            try
            {

                portlist_tscb.Items.Clear();
                string[] ports = SerialPort.GetPortNames();
                foreach (string port in ports)
                {

                    portlist_tscb.Items.Add(port);

                }
                if (portlist_tscb.Items.Count > 0) { portlist_tscb.SelectedIndex = 0; }

                else { MessageBox.Show(Properties.Strings.port_error); }

                }
            catch (Exception ex)
            { MessageBox.Show(Properties.Strings.port_error + " " + ex); }
        }

        public void Dpi()
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
            // Kullanıcıya uygulamayı yeniden başlatması gerektiğini soran bir mesaj kutusu gösteriyoruz
            DialogResult result = MessageBox.Show(Properties.Strings.language_change,
                                                  Properties.Strings.warning,
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

            // Eğer kullanıcı "OK" butonuna tıklarsa uygulama yeniden başlatılır
            if (result == DialogResult.OK)
            {
                Properties.Settings.Default.Lang = langs_tstrip_cb1.SelectedItem.ToString();
                Properties.Settings.Default.Save();
                Application.Restart();
            }
            // Eğer kullanıcı "Cancel" butonuna tıklarsa işlem iptal edilir
            else
            {
                // İptal edildiğinde yapılacak başka bir işlem varsa burada belirtilebilir
            }
        }


        private void Connection_tsbtn_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                connection_tsbtn.Text = Properties.Strings.connect;
                connection_tsbtn.BackColor = Color.LightGreen;
                portlist_tscb.Items.Clear();
                //Getportlist();
            }
            else { openport(); }
        }



        private void Clitbox_KeyDown(object sender, KeyEventArgs e)
        {

            if (clitbox.SelectionStart != clitbox.Text.Length)
            {
                // İmleci sona getir
                clitbox.SelectionStart = clitbox.Text.Length;
                clitbox.SelectionLength = 0;
            }

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Enter tuşunun TextBox'a yeni satır eklemesini engelle
                if (serialPort1.IsOpen)
                {
                    // Eğer detectedEndLine boşsa varsayılan karakterler gönder
                    if (string.IsNullOrEmpty(detectedEndLine))
                    {
                        serialPort1.Write("t");  // Varsayılan karakter (örnek olarak)
                        serialPort1.Write("\r");
                        serialPort1.Write("\n");
                        serialPort1.Write("\r\n");
                    }
                    else
                    {
                        // Boş değilse detectedEndLine'ı gönder
                        serialPort1.Write(detectedEndLine);
                    }
                }
                else
                {
                    MessageBox.Show(Properties.Strings.port_closed);
                }
            }




            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right ||e.KeyCode == Keys.Up || e.KeyCode == Keys.Down ||e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = true; // Tuş basımını devre dışı bırak
            }

            


           // if (e.KeyCode == Keys.F2) { cmd_cb.Text += clitbox.SelectedText; cmd_cb.Focus(); cmd_cb.SelectionStart = cmd_cb.Text.Length; cmd_cb.SelectionLength = 0; }
          //  if (e.KeyCode == Keys.F12) { saveascommand(); }
        }




        private string detectedEndLine = ""; // Otomatik algılanan satır sonu karakterini saklar


        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string response = serialPort1.ReadExisting();

                // Satır sonu karakterini otomatik algıla
                if (detectedEndLine == "")
                {
                    if (response.Contains("\r\n"))
                    {
                        detectedEndLine = "\r\n";
                        Invoke(new Action(() => Endline_cb.SelectedIndex = 3));
                    }
                    else if (response.Contains("\n"))
                    {
                        detectedEndLine = "\n";
                        Invoke(new Action(() => Endline_cb.SelectedIndex = 2));
                    }
                    else if (response.Contains("\r"))
                    {
                        detectedEndLine = "\r";
                        Invoke(new Action(() => Endline_cb.SelectedIndex = 1));
                    }
                }

                // Gelen veriyi doğrudan clitbox'a yazdır
                Invoke(new Action(() =>
                {
                    clitbox.AppendText(response); // Gelen veriyi yazdır
                    clitbox.SelectionStart = clitbox.Text.Length;
                    clitbox.ScrollToCaret();
                }));
            }
            catch
            {
                // Hata durumunu yönet
            }
        }




        private void portlist_tslabel_Click(object sender, EventArgs e)
        {
            Getportlist();
        }

        private void Command_lbox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void Command_lbox_DragEnter(object sender, DragEventArgs e)
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
            Getconfig();
        }

        private void Configlist()
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
            else { Configlist(); }
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
            //Main_Form1 form = this; // Eğer bu kod, Main_Form1 sınıfında yazılıysa
            //SaveComboBoxIndexes(form);
        }

        private void saveascommand()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {

                try
                {
                    saveFileDialog.Filter =Properties.Strings.text_file+ " (*.txt)|*.txt|"+Properties.Strings.all_file+ "(*.*)|*.*";
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

        private void Clitbox_DoubleClick(object sender, EventArgs e)
        {
            string a = clitbox.SelectedText.Trim();
            cmd_cb.Text = cmd_cb.Text + a + " ";
            cmd_cb.Focus();
            cmd_cb.SelectionStart = cmd_cb.Text.Length;
            cmd_cb.SelectionLength = 0;
        }

        private void inserttext()
        {
            try { command_lbox.Items.Insert(command_lbox.SelectedIndex, cmd_cb.Text); } catch (Exception) { MessageBox.Show(Properties.Strings.select_row); }
        }

        private void replacetext() { try { command_lbox.Items[command_lbox.SelectedIndex] = cmd_cb.Text; } catch (Exception) { MessageBox.Show(Properties.Strings.select_row); } }




       


        private void Baudrate_tscb_SelectedIndexChanged(object sender, EventArgs e)
        {
            baudrateToolStripMenuItem.Text = "Baudrate --> " + baudrate_tscb.Text;
        }

        private void Databit_tscb_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Dtr_tscb_SelectedIndexChanged(object sender, EventArgs e)
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
                        string data = ReplaceCommandData(command_lbox.Items[i].ToString());
                        
                        // Metni // işaretinden böl ve ilk kısmı al
                        string[] parts = data.Split(new[] { "//" }, StringSplitOptions.None);

                        // İlk kısmın sonundaki boşlukları kaldır
                        string firstPart = parts[0].TrimEnd();

                        Autocfg_procces.Value = i * progressStep;
                        string command = firstPart.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Last();
                        serialPort1.Write(command);

                        if (!string.IsNullOrEmpty(detectedEndLine))
                        {
                            serialPort1.Write(detectedEndLine); // Satır sonu karakterini gönder
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
                    { MessageBox.Show(Properties.Strings.select_row); }
                    else {
                        for (int i = command_lbox.SelectedIndex; i < itemCount; i++)
                        {
                            string data = ReplaceCommandData(command_lbox.Items[i].ToString());
                            string[] parts = data.Split(new[] { "//" }, StringSplitOptions.None);

                            // İlk kısmın sonundaki boşlukları kaldır
                            string firstPart = parts[0].TrimEnd();


                            Autocfg_procces.Value = i * progressStep;
                            string command = firstPart.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Last();
                            serialPort1.Write(command);

                            if (!string.IsNullOrEmpty(detectedEndLine))
                            {
                                serialPort1.Write(detectedEndLine); // Satır sonu karakterini gönder
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


        private void Autocfg_cmts_Click(object sender, EventArgs e)
        {
            otosend();
        }

        private void Startselectedrown_cmstrip_Click(object sender, EventArgs e)
        {
            otosend_selectedrow();
        }

        private void startcfg_btn_Click(object sender, EventArgs e)
        {
            otosend();
        }

        public static void SaveComboBoxIndexes(Main_Form1 form)
        {
            if (form == null)
                throw new ArgumentNullException(nameof(form)); // Null kontrolü

            using (StreamWriter writer = new StreamWriter("settings.ini"))
            {
                foreach (var comboBox in GetAllComboBoxes(form))
                {
                    if (!string.IsNullOrEmpty(comboBox.Name))
                    {
                        writer.WriteLine($"{comboBox.Name}={comboBox.SelectedIndex}");
                    }
                }
            }
        }

        // İç içe olan ComboBox'ları da bulan yardımcı fonksiyon
        private static IEnumerable<ComboBox> GetAllComboBoxes(Control control)
        {
            // Standart ComboBox'ları bul
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is ComboBox comboBox)
                {
                    yield return comboBox;
                }
                else if (ctrl.HasChildren)
                {
                    foreach (var childComboBox in GetAllComboBoxes(ctrl))
                    {
                        yield return childComboBox;
                    }
                }
            }

            // ToolStrip veya MenuStrip içerisindeki ToolStripComboBox'ları bul
            foreach (var strip in control.Controls.OfType<ToolStrip>())
            {
                foreach (var item in strip.Items.OfType<ToolStripComboBox>())
                {
                    yield return item.ComboBox; // ToolStripComboBox'ın ComboBox'ını döndür
                }
            }

            // MenuStrip içerisindeki ToolStripComboBox'ları bul
            foreach (var menu in control.Controls.OfType<MenuStrip>())
            {
                foreach (var item in menu.Items.OfType<ToolStripMenuItem>())
                {
                    foreach (var subItem in item.DropDownItems.OfType<ToolStripComboBox>())
                    {
                        yield return subItem.ComboBox; // ToolStripComboBox'ın ComboBox'ını döndür
                    }
                }
            }
        }

            public void LoadComboBoxIndexes(Form form)
        {
            if (File.Exists("settings.ini"))
            {
                var lines = File.ReadAllLines("settings.ini");
                foreach (var line in lines)
                {
                    var parts = line.Split('=');
                    if (parts.Length == 2)
                    {
                        if (form.Controls.Find(parts[0], true).FirstOrDefault() is ComboBox comboBox && int.TryParse(parts[1], out int selectedIndex))
                        {
                            comboBox.SelectedIndex = selectedIndex;
                        }
                    }
                }
            }
        }


        private void refreshfile_btn_Click(object sender, EventArgs e)
        {
            Configlist();

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
                a = Properties.Strings.sysnotfound;
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
                MessageBox.Show(ex.Message + Properties.Strings.syslistnotfound, Properties.Strings.notfound, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Getsyslist_btn_Click(object sender, EventArgs e)
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
                a = Properties.Strings.notfound;
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

        private void Find()
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
                MessageBox.Show(Properties.Strings.notfound);
            }

        }

        private void syslist_cb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                sysip_cb.Text = string.Empty;
                sysip_tslb.Text = Properties.Strings.sys_ip;
                Find();
                sysnamelist();
                iplist();
                //comboBox3.Focus();

            }

            if (e.KeyCode == Keys.Up)
            {
                e.SuppressKeyPress = true;
                try
                {
                    syslist_cb.SelectedIndex --;
                    syslist_cb.Focus();
                }

                catch (Exception)
                {
                    MessageBox.Show(Properties.Strings.range_error);
                    syslist_cb.SelectedIndex = 0;
                    syslist_cb.Focus();
                }

            }

            if (e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true;
                try
                {
                    syslist_cb.SelectedIndex ++ ;
                    syslist_cb.Focus();

                }
                catch (Exception)
                {
                    MessageBox.Show(Properties.Strings.range_error);
                    syslist_cb.SelectedIndex = syslist_cb.Items.Count - 1;
                    syslist_cb.Focus();
                }

            }
        }

        private void syslist_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            sysnamelist();
            iplist();
            for (int i = 0; i < Devices_cb.Items.Count; i++)
            {
                // Devices_cb'deki her öğeyi al
                string currentDevice = Devices_cb.Items[i].ToString();

                // Parantezden önceki kısmı al
                int parantezIndex = currentDevice.IndexOf("(");
                string deviceName = (parantezIndex > 0) ? currentDevice.Substring(0, parantezIndex).TrimEnd() : currentDevice.TrimEnd();

                // syslist_cb.Text içeriğinde sonundaki boşlukları kaldırılmış cihaz ismi var mı kontrol et
                if (syslist_cb.Text.Contains(deviceName))
                {
                    // Eğer syslist_cb.Text içerisinde bu öğe bulunursa, o indexi seç
                    Devices_cb.SelectedIndex = i;
                    break; // Bir öğe bulunduğunda döngüden çık
                }
            }

        }

        private void IPsfound_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sysfound_cb.SelectedIndex = IPsfound_cb.SelectedIndex;
                sysname_tslb.Text = Properties.Strings.sysname + " --> " + sysfound_cb.Text;
                sysip_tslb.Text = Properties.Strings.sys_ip + " --> " + IPsfound_cb.Text;
                sysIP_tb.Text = IPsfound_cb.Text;
                Getwayblock();
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

        private void Getway_set_SelectedItemChanged(object sender, EventArgs e)
        {
            Getwayblock();
        }

        private void Getwayblock()
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
            Getwayblock();
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

        private void Command_lbox_KeyDown(object sender, KeyEventArgs e)
        {
           

            if (e.KeyCode == Keys.Delete)
            {
                try { command_lbox.Items.RemoveAt(command_lbox.SelectedIndex); }
                catch { MessageBox.Show(Properties.Strings.error_select_list); }
            }
        }

        private void Command_lbox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    string data = ReplaceCommandData(command_lbox.SelectedItem.ToString());
                    string[] parts = data.Split(new[] { "//" }, StringSplitOptions.None);

                    // İlk kısmın sonundaki boşlukları kaldır
                    string firstPart = parts[0].TrimEnd();

                    serialPort1.Write(firstPart);

                    if (!string.IsNullOrEmpty(detectedEndLine))
                    {
                        serialPort1.Write(detectedEndLine); // Satır sonu karakterini gönder
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

        private void Edit_command_cmts_Click(object sender, EventArgs e)
        {
            int i = command_lbox.SelectedIndex;
            string data = ReplaceCommandData(command_lbox.Items[i].ToString());
            cmd_cb.Text = data; cmd_cb.Focus();
        }

        private void insertcmd_cmts_Click(object sender, EventArgs e)
        {
            command_lbox.Items.Add(cmd_cb.Text);
        }

        private void Saveascmd_cmts_Click(object sender, EventArgs e)
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

        private void Savecmd_cmts_Click(object sender, EventArgs e)
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

        private void Moveup_cmts_Click(object sender, EventArgs e)
        {
            MoveItem(-1);
        }

        private void Movedown_cmts_Click(object sender, EventArgs e)
        {
            MoveItem(1);
        }

        // Global değişken tanımları
        private string selectedEndline = ""; // Varsayılan olarak boş, yani satır sonu yok


        private void SuggestionBox_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void SuggestionBox_Click(object sender, EventArgs e)
        {
            InsertSelectedSuggestion();
            cmd_cb.Focus();
            cmd_cb.SelectionLength = 0; // Seçimi kaldır
            cmd_cb.SelectionStart = cmd_cb.Text.Length; // İmleci metnin sonuna getir
        }

        private void InsertSelectedSuggestion()
        {
            if (suggestionBox.SelectedItem != null)
            {
                string suggestion = suggestionBox.SelectedItem.ToString();

                // Metni // işaretinden böl ve ilk kısmı al
                string[] parts = suggestion.Split(new[] { "//" }, StringSplitOptions.None);

                // İlk kısmın sonundaki boşlukları kaldır
                string firstPart = parts[0].TrimEnd();
                string currentText = cmd_cb.Text;
                int lastSpaceIndex = currentText.LastIndexOf(' ');

                if (lastSpaceIndex > -1)
                {
                    // Son kelimeyi öneri ile değiştir
                    cmd_cb.Text = currentText.Substring(0, lastSpaceIndex + 1) + ReplaceCommandData(firstPart);
                }
                else
                {
                    // Tek kelime varsa doğrudan öneriyi ekle
                    cmd_cb.Text = ReplaceCommandData(firstPart);
                }

                cmd_cb.SelectionStart = cmd_cb.Text.Length; // İmleci sona al
                suggestionBox.Visible = false;
            }
        }

        private string[] GetSuggestions(string input)
        {
            // Komut listesinden girilen kelimeyle başlayan önerileri döndür
            //return commandList.Where(cmd => cmd.StartsWith(input, StringComparison.OrdinalIgnoreCase)).ToArray();
            // Eğer giriş boşsa, boş bir dizi döndür
            if (string.IsNullOrWhiteSpace(input))
            {
                return new string[0];
            }

            // Komut listesinden girilen kelimeyle başlayan önerileri al
            var suggestions = commandList.Where(cmd => cmd.StartsWith(input, StringComparison.OrdinalIgnoreCase)).ToArray();

            // Eğer öneri yoksa boş bir dizi döndür
            if (suggestions.Length == 0)
            {
                return new string[0];
                
            }

            // Önerileri döndür
            return suggestions;
        }

        private string GetLastWord(string input)
        {
            // Metnin son kelimesini döndür
            if (string.IsNullOrEmpty(input)) return string.Empty;
            string[] words = input.Split(' ');
            return words.Last();
        }
        private void Cmd_cb_KeyDown(object sender, KeyEventArgs e)
        {
            

            if (suggestionBox.Visible)
            {
                // Aşağı/Yukarı yön tuşları ile öneri kutusunda gezinme
                if (e.KeyCode == Keys.Down && suggestionBox.SelectedIndex < suggestionBox.Items.Count - 1)
                {
                    suggestionBox.SelectedIndex++;
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.Up && suggestionBox.SelectedIndex > 0)
                {
                    suggestionBox.SelectedIndex--;
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.Right) // Sağ ok tuşu ile öneriyi seçme
                {
                    InsertSelectedSuggestion();
                    cmd_cb.Text += " ";
                    suggestionBox.Visible = false;
                    cmd_cb.SelectionStart = cmd_cb.Text.Length; // İmleci sona al
                    e.Handled = true;
                }
            }
            else
            {
                // Öneri kutusu görünmüyorsa cmd_cb'de gezinme işlemi

                if (e.KeyCode == Keys.Up)
                {
                    // Yukarı ok tuşuna basıldığında önceki değeri çağırın
                    e.SuppressKeyPress = true;
                    try
                    {
                        if (cmd_cb.Items.Count > 0)
                        {
                            if (cmd_cb.SelectedIndex <= 0) { cmd_cb.SelectedIndex = cmd_cb.Items.Count - 1; }
                            else { cmd_cb.SelectedIndex --; }
                        }
                    }
                    catch { }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    // Aşağı ok tuşuna basıldığında sonraki değeri çağırın
                    e.SuppressKeyPress = true;
                    try
                    {
                        if (cmd_cb.SelectedIndex == cmd_cb.Items.Count - 1) { cmd_cb.SelectedIndex = 0; }
                        else { cmd_cb.SelectedIndex ++; }
                    }
                    catch { }
                }
            }

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Enter tuşunun TextBox'a yeni satır eklemesini engelle
                if (serialPort1.IsOpen)
                {
                    // Komutu sonlandırmadan gönder, ardından seçilen endline karakterini gönder
                    string command = ReplaceCommandData(cmd_cb.Text.TrimEnd()).Split(new[] { Environment.NewLine }, StringSplitOptions.None).Last();
                    serialPort1.Write(command); // Komutu gönder
                    if (!string.IsNullOrEmpty(detectedEndLine))
                    {
                        serialPort1.Write(detectedEndLine); // Satır sonu karakterini gönder
                    }
                    cmd_cb.Items.Add(cmd_cb.Text);
                    cmd_cb.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show(Properties.Strings.port_closed);
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

                // Label ve ComboBox isimlerini dizi olarak tanımlıyoruz
                string[] labelNames = { "val1_lb", "val2_lb", "val3_lb", "val4_lb", "val5_lb", "val6_lb", "val7_lb", "val8_lb", "devices_lb" };
                string[] comboBoxNames = { "val1_cb", "val2_cb", "val3_cb", "val4_cb", "val5_cb", "val6_cb", "val7_cb", "val8_cb", "devices_cb" };

                foreach (var line in lines)
                {
                    for (int i = 0; i < labelNames.Length; i++)  // Dizi üzerinde döngü ile ilerliyoruz
                    {
                        string labelName = labelNames[i];    // İlgili label ismi
                        string comboBoxName = comboBoxNames[i]; // İlgili comboBox ismi

                        if (line.Contains(labelName))  // Satırda labelName geçiyorsa işleme devam et
                        {
                            var parts = line.Split(new[] { '=', '|' }, StringSplitOptions.RemoveEmptyEntries);
                            if (parts.Length == 4)
                            {
                                // Label'ı bul ve metni güncelle
                                if (this.Controls.Find(labelName, true).FirstOrDefault() is System.Windows.Forms.Label label)
                                {
                                    label.Text = parts[1].Trim();
                                }

                                // ComboBox değerlerini ayarla
                                var comboBoxValues = parts[2].Split('>')
                                                             .Select(v => v.Trim())
                                                             .ToArray();
                                if (this.Controls.Find(comboBoxName, true).FirstOrDefault() is System.Windows.Forms.ComboBox comboBox)
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
            catch
            {
                // Hata olduğunda sessizce devam et
            }
        }


        private void syslist_template_tsmn_Click(object sender, EventArgs e)
        {
            defines.sample_syslist();
        }

        private void template_sample_tsmn_Click(object sender, EventArgs e)
        {
            
        }

        private void Define_template_tsmn_Click(object sender, EventArgs e)
        {
            defines.sample_defines();
        }

        private void NokiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            defines.samplenokiacmd();  
        }

        private void ZTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            defines.sampleztecmd();
        }

        private void HuaweiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            defines.samplehuaweicmd();  
        }

       

        private void Endline_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Endline_cb.SelectedItem.ToString())
            {
                case "\\r":
                    selectedEndline = "\r"; // \r karakterini ata
                    detectedEndLine = "\r";
                    break;
                case "\\n":
                    selectedEndline = "\n"; // \n karakterini ata
                    detectedEndLine = "\n";
                    break;
                case "\\r\\n":
                    selectedEndline = "\r\n"; // \r\n karakterini ata
                    detectedEndLine = "\r\n";
                    break;
                case "null":
                    selectedEndline = ""; // \r\n karakterini ata
                    detectedEndLine= "";
                    break;
            }
        }

        private void Main_Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Cmd_cb_TextChanged(object sender, EventArgs e)
        {
            string currentText = GetLastWord(cmd_cb.Text);
            

            if (string.IsNullOrEmpty(currentText))
            {
                suggestionBox.Visible = false; // Eğer boşsa öneri kutusunu gizle
                return;
            }

            var suggestions = GetSuggestions(currentText);

            // Eğer öneri varsa işlemi devam ettir, yoksa gizle
            if (suggestions != null && suggestions.Length > 0)
            {
                Point caretPosition = GetCaretPosition(cmd_cb);

                // Öneri kutusunun konumunu ayarla (Metnin sonuna göre, 10 piksel sağına ve ComboBox'ın yüksekliğine göre)
                suggestionBox.Location = new Point(caretPosition.X + 10, caretPosition.Y + cmd_cb.Height - 70);
                suggestionBox.Items.Clear();
                suggestionBox.Items.AddRange(suggestions.ToArray());
                suggestionBox.Visible = true;
                suggestionBox.BringToFront();
            }
            else
            {
                suggestionBox.Items.Clear();
                suggestionBox.Visible = false; // Eğer öneri yoksa kutuyu gizle
            }
        }



        private Point GetCaretPosition(ComboBox comboBox)
        {
            // ComboBox içindeki metni al
            string text = comboBox.Text;

            // Metnin genişliğini hesapla (son karakterin pozisyonunu almak için)
            Size textSize = TextRenderer.MeasureText(text, comboBox.Font);

            // ComboBox'ın form içindeki konumunu al
            Point comboBoxLocation = comboBox.Location;

            // Metin genişliğine göre pozisyonu ayarla
            // textSize.Width -> Metnin genişliği, bu son harfin pozisyonunu verir
            return new Point(comboBoxLocation.X + textSize.Width, comboBoxLocation.Y);
        }

        private void Cmd_cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen && e.KeyChar == '?')
                {
                    // SerialPort'a ? ile komut yazma işlemini gerçekleştiriyoruz
                    serialPort1.Write(cmd_cb.Text);
                    cmd_cb.Text=string.Empty;
                }
            } catch { }
        }

        private void Clitbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                // Enter tuşuna basılmadıysa işlemleri yap
                if (e.KeyChar != (char)Keys.Enter)
                {
                    e.Handled = true;

                    // Eğer Tab tuşuna basıldıysa '\t' karakteri olarak gönder
                    if (e.KeyChar == (char)Keys.Tab)
                    {
                        serialPort1.Write("\t");
                    }
                    else
                    {
                        // Diğer karakterler için doğrudan gönder
                        serialPort1.Write(e.KeyChar.ToString());
                    }
                }
            }
            catch
            {
                // Hata oluştuğunda işlemi atla
            }
        }


        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clitbox.SelectedText.Length > 0)
            {
                Clipboard.SetText(clitbox.SelectedText); // Seçili metni kopyala
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Seri portun açık olup olmadığını kontrol et
            if (serialPort1.IsOpen)
            {
                if (Clipboard.ContainsText())
                {
                    string textToPaste = Clipboard.GetText();

                    // Seri porta metni gönder
                    serialPort1.Write(textToPaste);
                }
            }
            else
            {
                MessageBox.Show(Properties.Strings.port_closed, Properties.Strings.warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clitbox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.IsInputKey = true; // Tab tuşunun özel bir anahtar olarak işlenmesini sağlar
            }

        }

        private void sendCMDLineForEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmd_cb.Text += clitbox.SelectedText; cmd_cb.Focus(); cmd_cb.SelectionStart = cmd_cb.Text.Length; cmd_cb.SelectionLength = 0;
        }

        private void saveAsCLIPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveascommand();
        }

       
    }
}
