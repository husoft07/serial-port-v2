namespace Serial_Port
{
    partial class Main_Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lang_tstripmenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.langs_tstrip_cb1 = new System.Windows.Forms.ToolStripComboBox();
            this.connectset_tsmn = new System.Windows.Forms.ToolStripMenuItem();
            this.portToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baudrateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baudrate_tscb = new System.Windows.Forms.ToolStripComboBox();
            this.dataBitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databit_tscb = new System.Windows.Forms.ToolStripComboBox();
            this.parityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parity_tscb = new System.Windows.Forms.ToolStripComboBox();
            this.stopBitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopbit_tscb = new System.Windows.Forms.ToolStripComboBox();
            this.dTREnableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtr_tscb = new System.Windows.Forms.ToolStripComboBox();
            this.templates_tsmn = new System.Windows.Forms.ToolStripMenuItem();
            this.template_sample_tsmn = new System.Windows.Forms.ToolStripMenuItem();
            this.nokiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huaweiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.define_template_tsmn = new System.Windows.Forms.ToolStripMenuItem();
            this.syslist_template_tsmn = new System.Windows.Forms.ToolStripMenuItem();
            this.help_tsmn = new System.Windows.Forms.ToolStripMenuItem();
            this.about_tsmn = new System.Windows.Forms.ToolStripMenuItem();
            this.appdetail_tsmn = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.command_procces = new System.Windows.Forms.ToolStripStatusLabel();
            this.Autocfg_procces = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.lang_tstripmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.langs_tstrip_cb = new System.Windows.Forms.ToolStripComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.CLIpanel = new System.Windows.Forms.Panel();
            this.clitbox = new System.Windows.Forms.TextBox();
            this.cmd_cb = new System.Windows.Forms.ComboBox();
            this.cmd_cb_menustrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.save_cmd_cb_cmts = new System.Windows.Forms.ToolStripMenuItem();
            this.replace_cmd_cb_cmts = new System.Windows.Forms.ToolStripMenuItem();
            this.insert_selectedrow_cmd_cb_cmts = new System.Windows.Forms.ToolStripMenuItem();
            this.insert_endline_cmd_cb_cmts = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.portlist_tslabel = new System.Windows.Forms.ToolStripLabel();
            this.portlist_tscb = new System.Windows.Forms.ToolStripComboBox();
            this.connection_tsbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sysip_tslb = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sysname_tslb = new System.Windows.Forms.ToolStripLabel();
            this.setting_panel = new System.Windows.Forms.Panel();
            this.command_tabpanel = new System.Windows.Forms.TabControl();
            this.defines_tab = new System.Windows.Forms.TabPage();
            this.define_gb = new System.Windows.Forms.GroupBox();
            this.val8_lb = new System.Windows.Forms.Label();
            this.val7_lb = new System.Windows.Forms.Label();
            this.val6_lb = new System.Windows.Forms.Label();
            this.val5_lb = new System.Windows.Forms.Label();
            this.val4_lb = new System.Windows.Forms.Label();
            this.val3_lb = new System.Windows.Forms.Label();
            this.val2_lb = new System.Windows.Forms.Label();
            this.val1_lb = new System.Windows.Forms.Label();
            this.routeip_lb = new System.Windows.Forms.Label();
            this.sysip_lb = new System.Windows.Forms.Label();
            this.val6_cb = new System.Windows.Forms.ComboBox();
            this.val5_cb = new System.Windows.Forms.ComboBox();
            this.val4_cb = new System.Windows.Forms.ComboBox();
            this.val3_cb = new System.Windows.Forms.ComboBox();
            this.val2_cb = new System.Windows.Forms.ComboBox();
            this.val1_cb = new System.Windows.Forms.ComboBox();
            this.val7_cb = new System.Windows.Forms.ComboBox();
            this.val8_cb = new System.Windows.Forms.ComboBox();
            this.routip_cb = new System.Windows.Forms.ComboBox();
            this.sysip_cb = new System.Windows.Forms.ComboBox();
            this.Endline_lb = new System.Windows.Forms.Label();
            this.Device_lb = new System.Windows.Forms.Label();
            this.Endline_cb = new System.Windows.Forms.ComboBox();
            this.getway_set = new System.Windows.Forms.DomainUpDown();
            this.Devices_cb = new System.Windows.Forms.ComboBox();
            this.sysfound_cb = new System.Windows.Forms.ComboBox();
            this.sysfound_lb = new System.Windows.Forms.Label();
            this.IPsfound_cb = new System.Windows.Forms.ComboBox();
            this.IPsfound_lb = new System.Windows.Forms.Label();
            this.GetwayIP_tb = new System.Windows.Forms.TextBox();
            this.getwayIP = new System.Windows.Forms.Label();
            this.getsyslist_btn = new System.Windows.Forms.Button();
            this.syslist_cb = new System.Windows.Forms.ComboBox();
            this.sysIP_tb = new System.Windows.Forms.TextBox();
            this.sysIP = new System.Windows.Forms.Label();
            this.precommand_tab = new System.Windows.Forms.TabPage();
            this.command_lbox = new System.Windows.Forms.ListBox();
            this.Commandlbox_MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.autocfg_cmts = new System.Windows.Forms.ToolStripMenuItem();
            this.startselectedrown_cmstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_command_cmts = new System.Windows.Forms.ToolStripMenuItem();
            this.saveascmd_cmts = new System.Windows.Forms.ToolStripMenuItem();
            this.savecmd_cmts = new System.Windows.Forms.ToolStripMenuItem();
            this.Replace_selected_row_cmts = new System.Windows.Forms.ToolStripMenuItem();
            this.insert_between_cmd_cmts = new System.Windows.Forms.ToolStripMenuItem();
            this.insertcmd_cmts = new System.Windows.Forms.ToolStripMenuItem();
            this.moveup_cmts = new System.Windows.Forms.ToolStripMenuItem();
            this.movedown_cmts = new System.Windows.Forms.ToolStripMenuItem();
            this.startcfg_btn = new System.Windows.Forms.Button();
            this.refreshfile_btn = new System.Windows.Forms.Button();
            this.FilePathBox = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.CLIpanel.SuspendLayout();
            this.cmd_cb_menustrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.setting_panel.SuspendLayout();
            this.command_tabpanel.SuspendLayout();
            this.defines_tab.SuspendLayout();
            this.define_gb.SuspendLayout();
            this.precommand_tab.SuspendLayout();
            this.Commandlbox_MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lang_tstripmenu1,
            this.connectset_tsmn,
            this.templates_tsmn,
            this.help_tsmn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1289, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lang_tstripmenu1
            // 
            this.lang_tstripmenu1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.langs_tstrip_cb1});
            this.lang_tstripmenu1.Name = "lang_tstripmenu1";
            this.lang_tstripmenu1.Size = new System.Drawing.Size(46, 20);
            this.lang_tstripmenu1.Text = "Diller";
            // 
            // langs_tstrip_cb1
            // 
            this.langs_tstrip_cb1.Name = "langs_tstrip_cb1";
            this.langs_tstrip_cb1.Size = new System.Drawing.Size(121, 23);
            this.langs_tstrip_cb1.SelectedIndexChanged += new System.EventHandler(this.langs_tstrip_cb1_SelectedIndexChanged);
            // 
            // connectset_tsmn
            // 
            this.connectset_tsmn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portToolStripMenuItem,
            this.baudrateToolStripMenuItem,
            this.dataBitToolStripMenuItem,
            this.parityToolStripMenuItem,
            this.stopBitToolStripMenuItem,
            this.dTREnableToolStripMenuItem});
            this.connectset_tsmn.Name = "connectset_tsmn";
            this.connectset_tsmn.Size = new System.Drawing.Size(105, 20);
            this.connectset_tsmn.Text = "Bağlantı Ayarları";
            // 
            // portToolStripMenuItem
            // 
            this.portToolStripMenuItem.Name = "portToolStripMenuItem";
            this.portToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.portToolStripMenuItem.Text = "Port";
            // 
            // baudrateToolStripMenuItem
            // 
            this.baudrateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baudrate_tscb});
            this.baudrateToolStripMenuItem.Name = "baudrateToolStripMenuItem";
            this.baudrateToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.baudrateToolStripMenuItem.Text = "Baudrate";
            // 
            // baudrate_tscb
            // 
            this.baudrate_tscb.Name = "baudrate_tscb";
            this.baudrate_tscb.Size = new System.Drawing.Size(121, 23);
            this.baudrate_tscb.SelectedIndexChanged += new System.EventHandler(this.baudrate_tscb_SelectedIndexChanged);
            // 
            // dataBitToolStripMenuItem
            // 
            this.dataBitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databit_tscb});
            this.dataBitToolStripMenuItem.Name = "dataBitToolStripMenuItem";
            this.dataBitToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.dataBitToolStripMenuItem.Text = "Data Bit";
            // 
            // databit_tscb
            // 
            this.databit_tscb.Name = "databit_tscb";
            this.databit_tscb.Size = new System.Drawing.Size(121, 23);
            this.databit_tscb.SelectedIndexChanged += new System.EventHandler(this.databit_tscb_SelectedIndexChanged);
            // 
            // parityToolStripMenuItem
            // 
            this.parityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parity_tscb});
            this.parityToolStripMenuItem.Name = "parityToolStripMenuItem";
            this.parityToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.parityToolStripMenuItem.Text = "Parity";
            // 
            // parity_tscb
            // 
            this.parity_tscb.Name = "parity_tscb";
            this.parity_tscb.Size = new System.Drawing.Size(121, 23);
            this.parity_tscb.SelectedIndexChanged += new System.EventHandler(this.parity_tscb_SelectedIndexChanged);
            // 
            // stopBitToolStripMenuItem
            // 
            this.stopBitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopbit_tscb});
            this.stopBitToolStripMenuItem.Name = "stopBitToolStripMenuItem";
            this.stopBitToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.stopBitToolStripMenuItem.Text = "Stop Bit";
            // 
            // stopbit_tscb
            // 
            this.stopbit_tscb.Name = "stopbit_tscb";
            this.stopbit_tscb.Size = new System.Drawing.Size(121, 23);
            this.stopbit_tscb.SelectedIndexChanged += new System.EventHandler(this.stopbit_tscb_SelectedIndexChanged);
            // 
            // dTREnableToolStripMenuItem
            // 
            this.dTREnableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dtr_tscb});
            this.dTREnableToolStripMenuItem.Name = "dTREnableToolStripMenuItem";
            this.dTREnableToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.dTREnableToolStripMenuItem.Text = "DTREnable";
            // 
            // dtr_tscb
            // 
            this.dtr_tscb.Name = "dtr_tscb";
            this.dtr_tscb.Size = new System.Drawing.Size(121, 23);
            this.dtr_tscb.SelectedIndexChanged += new System.EventHandler(this.dtr_tscb_SelectedIndexChanged);
            // 
            // templates_tsmn
            // 
            this.templates_tsmn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.template_sample_tsmn,
            this.define_template_tsmn,
            this.syslist_template_tsmn});
            this.templates_tsmn.Name = "templates_tsmn";
            this.templates_tsmn.Size = new System.Drawing.Size(68, 20);
            this.templates_tsmn.Text = "Şablonlar";
            // 
            // template_sample_tsmn
            // 
            this.template_sample_tsmn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nokiaToolStripMenuItem,
            this.zTEToolStripMenuItem,
            this.huaweiToolStripMenuItem});
            this.template_sample_tsmn.Name = "template_sample_tsmn";
            this.template_sample_tsmn.Size = new System.Drawing.Size(225, 22);
            this.template_sample_tsmn.Text = "Örnek Komut Şablonu";
            this.template_sample_tsmn.Click += new System.EventHandler(this.template_sample_tsmn_Click);
            // 
            // nokiaToolStripMenuItem
            // 
            this.nokiaToolStripMenuItem.Name = "nokiaToolStripMenuItem";
            this.nokiaToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.nokiaToolStripMenuItem.Text = "Nokia";
            this.nokiaToolStripMenuItem.Click += new System.EventHandler(this.nokiaToolStripMenuItem_Click);
            // 
            // zTEToolStripMenuItem
            // 
            this.zTEToolStripMenuItem.Name = "zTEToolStripMenuItem";
            this.zTEToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.zTEToolStripMenuItem.Text = "ZTE";
            this.zTEToolStripMenuItem.Click += new System.EventHandler(this.zTEToolStripMenuItem_Click);
            // 
            // huaweiToolStripMenuItem
            // 
            this.huaweiToolStripMenuItem.Name = "huaweiToolStripMenuItem";
            this.huaweiToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.huaweiToolStripMenuItem.Text = "Huawei";
            this.huaweiToolStripMenuItem.Click += new System.EventHandler(this.huaweiToolStripMenuItem_Click);
            // 
            // define_template_tsmn
            // 
            this.define_template_tsmn.Name = "define_template_tsmn";
            this.define_template_tsmn.Size = new System.Drawing.Size(225, 22);
            this.define_template_tsmn.Text = "Örnek Tanım Şablonu";
            this.define_template_tsmn.Click += new System.EventHandler(this.define_template_tsmn_Click);
            // 
            // syslist_template_tsmn
            // 
            this.syslist_template_tsmn.Name = "syslist_template_tsmn";
            this.syslist_template_tsmn.Size = new System.Drawing.Size(225, 22);
            this.syslist_template_tsmn.Text = "Örnek Sistem Listesi Şablonu";
            this.syslist_template_tsmn.Click += new System.EventHandler(this.syslist_template_tsmn_Click);
            // 
            // help_tsmn
            // 
            this.help_tsmn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about_tsmn,
            this.appdetail_tsmn});
            this.help_tsmn.Name = "help_tsmn";
            this.help_tsmn.Size = new System.Drawing.Size(56, 20);
            this.help_tsmn.Text = "Yardım";
            // 
            // about_tsmn
            // 
            this.about_tsmn.Name = "about_tsmn";
            this.about_tsmn.Size = new System.Drawing.Size(181, 22);
            this.about_tsmn.Text = "Uygulama Hakkında";
            // 
            // appdetail_tsmn
            // 
            this.appdetail_tsmn.Name = "appdetail_tsmn";
            this.appdetail_tsmn.Size = new System.Drawing.Size(181, 22);
            this.appdetail_tsmn.Text = "Kullanım Detayları";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.command_procces,
            this.Autocfg_procces});
            this.statusStrip1.Location = new System.Drawing.Point(0, 774);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1289, 29);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // command_procces
            // 
            this.command_procces.Name = "command_procces";
            this.command_procces.Size = new System.Drawing.Size(141, 24);
            this.command_procces.Text = "Otomatik Komut İlerleme";
            // 
            // Autocfg_procces
            // 
            this.Autocfg_procces.Name = "Autocfg_procces";
            this.Autocfg_procces.Size = new System.Drawing.Size(117, 23);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // lang_tstripmenu
            // 
            this.lang_tstripmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.langs_tstrip_cb});
            this.lang_tstripmenu.Name = "lang_tstripmenu";
            this.lang_tstripmenu.Size = new System.Drawing.Size(33, 20);
            this.lang_tstripmenu.Text = "Dil";
            // 
            // langs_tstrip_cb
            // 
            this.langs_tstrip_cb.Name = "langs_tstrip_cb";
            this.langs_tstrip_cb.Size = new System.Drawing.Size(121, 23);
            // 
            // serialPort1
            // 
            this.serialPort1.ReadTimeout = 1000;
            this.serialPort1.WriteTimeout = 1000;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // CLIpanel
            // 
            this.CLIpanel.BackColor = System.Drawing.Color.MistyRose;
            this.CLIpanel.Controls.Add(this.clitbox);
            this.CLIpanel.Controls.Add(this.cmd_cb);
            this.CLIpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CLIpanel.Location = new System.Drawing.Point(0, 49);
            this.CLIpanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.CLIpanel.Name = "CLIpanel";
            this.CLIpanel.Size = new System.Drawing.Size(824, 725);
            this.CLIpanel.TabIndex = 4;
            // 
            // clitbox
            // 
            this.clitbox.BackColor = System.Drawing.Color.PapayaWhip;
            this.clitbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clitbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clitbox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.clitbox.Location = new System.Drawing.Point(0, 0);
            this.clitbox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.clitbox.Multiline = true;
            this.clitbox.Name = "clitbox";
            this.clitbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.clitbox.Size = new System.Drawing.Size(824, 696);
            this.clitbox.TabIndex = 0;
            this.clitbox.Text = "Test";
            this.clitbox.DoubleClick += new System.EventHandler(this.clitbox_DoubleClick);
            this.clitbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clitbox_KeyDown);
            // 
            // cmd_cb
            // 
            this.cmd_cb.ContextMenuStrip = this.cmd_cb_menustrip;
            this.cmd_cb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmd_cb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmd_cb.FormattingEnabled = true;
            this.cmd_cb.Location = new System.Drawing.Point(0, 696);
            this.cmd_cb.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmd_cb.Name = "cmd_cb";
            this.cmd_cb.Size = new System.Drawing.Size(824, 29);
            this.cmd_cb.TabIndex = 1;
            this.cmd_cb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmd_cb_KeyDown);
            // 
            // cmd_cb_menustrip
            // 
            this.cmd_cb_menustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.save_cmd_cb_cmts,
            this.replace_cmd_cb_cmts,
            this.insert_selectedrow_cmd_cb_cmts,
            this.insert_endline_cmd_cb_cmts});
            this.cmd_cb_menustrip.Name = "cmd_cb_menustrip";
            this.cmd_cb_menustrip.Size = new System.Drawing.Size(288, 92);
            // 
            // save_cmd_cb_cmts
            // 
            this.save_cmd_cb_cmts.Name = "save_cmd_cb_cmts";
            this.save_cmd_cb_cmts.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.save_cmd_cb_cmts.Size = new System.Drawing.Size(287, 22);
            this.save_cmd_cb_cmts.Text = "Kaydet";
            this.save_cmd_cb_cmts.Click += new System.EventHandler(this.save_cmd_cb_cmts_Click);
            // 
            // replace_cmd_cb_cmts
            // 
            this.replace_cmd_cb_cmts.Name = "replace_cmd_cb_cmts";
            this.replace_cmd_cb_cmts.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.replace_cmd_cb_cmts.Size = new System.Drawing.Size(287, 22);
            this.replace_cmd_cb_cmts.Text = "Seçili Satırdaki Komut ile Değiştir";
            this.replace_cmd_cb_cmts.Click += new System.EventHandler(this.replace_cmd_cb_cmts_Click);
            // 
            // insert_selectedrow_cmd_cb_cmts
            // 
            this.insert_selectedrow_cmd_cb_cmts.Name = "insert_selectedrow_cmd_cb_cmts";
            this.insert_selectedrow_cmd_cb_cmts.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.insert_selectedrow_cmd_cb_cmts.Size = new System.Drawing.Size(287, 22);
            this.insert_selectedrow_cmd_cb_cmts.Text = "Seçili Satıra Ekle";
            this.insert_selectedrow_cmd_cb_cmts.Click += new System.EventHandler(this.insert_selectedrow_cmd_cb_cmts_Click);
            // 
            // insert_endline_cmd_cb_cmts
            // 
            this.insert_endline_cmd_cb_cmts.Name = "insert_endline_cmd_cb_cmts";
            this.insert_endline_cmd_cb_cmts.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.insert_endline_cmd_cb_cmts.Size = new System.Drawing.Size(287, 22);
            this.insert_endline_cmd_cb_cmts.Text = "Komut Listesine Ekle";
            this.insert_endline_cmd_cb_cmts.Click += new System.EventHandler(this.insert_endline_cmd_cb_cmts_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portlist_tslabel,
            this.portlist_tscb,
            this.connection_tsbtn,
            this.toolStripSeparator1,
            this.sysip_tslb,
            this.toolStripSeparator2,
            this.sysname_tslb});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1289, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "quickmenu_strip";
            // 
            // portlist_tslabel
            // 
            this.portlist_tslabel.Name = "portlist_tslabel";
            this.portlist_tslabel.Size = new System.Drawing.Size(71, 22);
            this.portlist_tslabel.Text = "Port Listesi";
            this.portlist_tslabel.Click += new System.EventHandler(this.portlist_tslabel_Click);
            // 
            // portlist_tscb
            // 
            this.portlist_tscb.Name = "portlist_tscb";
            this.portlist_tscb.Size = new System.Drawing.Size(140, 25);
            this.portlist_tscb.SelectedIndexChanged += new System.EventHandler(this.portlist_tscb_SelectedIndexChanged);
            // 
            // connection_tsbtn
            // 
            this.connection_tsbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.connection_tsbtn.Image = ((System.Drawing.Image)(resources.GetObject("connection_tsbtn.Image")));
            this.connection_tsbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.connection_tsbtn.Name = "connection_tsbtn";
            this.connection_tsbtn.Size = new System.Drawing.Size(51, 22);
            this.connection_tsbtn.Text = "Bağlan";
            this.connection_tsbtn.Click += new System.EventHandler(this.connection_tsbtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // sysip_tslb
            // 
            this.sysip_tslb.Name = "sysip_tslb";
            this.sysip_tslb.Size = new System.Drawing.Size(60, 22);
            this.sysip_tslb.Text = "Sistem IP";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // sysname_tslb
            // 
            this.sysname_tslb.Name = "sysname_tslb";
            this.sysname_tslb.Size = new System.Drawing.Size(69, 22);
            this.sysname_tslb.Text = "Sistem Adı";
            // 
            // setting_panel
            // 
            this.setting_panel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.setting_panel.Controls.Add(this.command_tabpanel);
            this.setting_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.setting_panel.Location = new System.Drawing.Point(824, 49);
            this.setting_panel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.setting_panel.Name = "setting_panel";
            this.setting_panel.Size = new System.Drawing.Size(465, 725);
            this.setting_panel.TabIndex = 7;
            // 
            // command_tabpanel
            // 
            this.command_tabpanel.Controls.Add(this.defines_tab);
            this.command_tabpanel.Controls.Add(this.precommand_tab);
            this.command_tabpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.command_tabpanel.Location = new System.Drawing.Point(0, 0);
            this.command_tabpanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.command_tabpanel.Name = "command_tabpanel";
            this.command_tabpanel.SelectedIndex = 0;
            this.command_tabpanel.Size = new System.Drawing.Size(465, 725);
            this.command_tabpanel.TabIndex = 0;
            // 
            // defines_tab
            // 
            this.defines_tab.Controls.Add(this.define_gb);
            this.defines_tab.Controls.Add(this.Endline_lb);
            this.defines_tab.Controls.Add(this.Device_lb);
            this.defines_tab.Controls.Add(this.Endline_cb);
            this.defines_tab.Controls.Add(this.getway_set);
            this.defines_tab.Controls.Add(this.Devices_cb);
            this.defines_tab.Controls.Add(this.sysfound_cb);
            this.defines_tab.Controls.Add(this.sysfound_lb);
            this.defines_tab.Controls.Add(this.IPsfound_cb);
            this.defines_tab.Controls.Add(this.IPsfound_lb);
            this.defines_tab.Controls.Add(this.GetwayIP_tb);
            this.defines_tab.Controls.Add(this.getwayIP);
            this.defines_tab.Controls.Add(this.getsyslist_btn);
            this.defines_tab.Controls.Add(this.syslist_cb);
            this.defines_tab.Controls.Add(this.sysIP_tb);
            this.defines_tab.Controls.Add(this.sysIP);
            this.defines_tab.Location = new System.Drawing.Point(4, 26);
            this.defines_tab.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.defines_tab.Name = "defines_tab";
            this.defines_tab.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.defines_tab.Size = new System.Drawing.Size(457, 695);
            this.defines_tab.TabIndex = 0;
            this.defines_tab.Text = "Tanımlar";
            this.defines_tab.UseVisualStyleBackColor = true;
            // 
            // define_gb
            // 
            this.define_gb.Controls.Add(this.val8_lb);
            this.define_gb.Controls.Add(this.val7_lb);
            this.define_gb.Controls.Add(this.val6_lb);
            this.define_gb.Controls.Add(this.val5_lb);
            this.define_gb.Controls.Add(this.val4_lb);
            this.define_gb.Controls.Add(this.val3_lb);
            this.define_gb.Controls.Add(this.val2_lb);
            this.define_gb.Controls.Add(this.val1_lb);
            this.define_gb.Controls.Add(this.routeip_lb);
            this.define_gb.Controls.Add(this.sysip_lb);
            this.define_gb.Controls.Add(this.val6_cb);
            this.define_gb.Controls.Add(this.val5_cb);
            this.define_gb.Controls.Add(this.val4_cb);
            this.define_gb.Controls.Add(this.val3_cb);
            this.define_gb.Controls.Add(this.val2_cb);
            this.define_gb.Controls.Add(this.val1_cb);
            this.define_gb.Controls.Add(this.val7_cb);
            this.define_gb.Controls.Add(this.val8_cb);
            this.define_gb.Controls.Add(this.routip_cb);
            this.define_gb.Controls.Add(this.sysip_cb);
            this.define_gb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.define_gb.Location = new System.Drawing.Point(4, 327);
            this.define_gb.Name = "define_gb";
            this.define_gb.Size = new System.Drawing.Size(449, 366);
            this.define_gb.TabIndex = 36;
            this.define_gb.TabStop = false;
            this.define_gb.Text = "Tanımlar";
            // 
            // val8_lb
            // 
            this.val8_lb.AutoSize = true;
            this.val8_lb.Location = new System.Drawing.Point(12, 321);
            this.val8_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.val8_lb.Name = "val8_lb";
            this.val8_lb.Size = new System.Drawing.Size(41, 17);
            this.val8_lb.TabIndex = 75;
            this.val8_lb.Text = "\"val8\"";
            // 
            // val7_lb
            // 
            this.val7_lb.AutoSize = true;
            this.val7_lb.Location = new System.Drawing.Point(12, 294);
            this.val7_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.val7_lb.Name = "val7_lb";
            this.val7_lb.Size = new System.Drawing.Size(41, 17);
            this.val7_lb.TabIndex = 74;
            this.val7_lb.Text = "\"val7\"";
            // 
            // val6_lb
            // 
            this.val6_lb.AutoSize = true;
            this.val6_lb.Location = new System.Drawing.Point(12, 262);
            this.val6_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.val6_lb.Name = "val6_lb";
            this.val6_lb.Size = new System.Drawing.Size(41, 17);
            this.val6_lb.TabIndex = 73;
            this.val6_lb.Text = "\"val6\"";
            // 
            // val5_lb
            // 
            this.val5_lb.AutoSize = true;
            this.val5_lb.Location = new System.Drawing.Point(12, 231);
            this.val5_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.val5_lb.Name = "val5_lb";
            this.val5_lb.Size = new System.Drawing.Size(41, 17);
            this.val5_lb.TabIndex = 72;
            this.val5_lb.Text = "\"val5\"";
            // 
            // val4_lb
            // 
            this.val4_lb.AutoSize = true;
            this.val4_lb.Location = new System.Drawing.Point(12, 203);
            this.val4_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.val4_lb.Name = "val4_lb";
            this.val4_lb.Size = new System.Drawing.Size(41, 17);
            this.val4_lb.TabIndex = 71;
            this.val4_lb.Text = "\"val4\"";
            // 
            // val3_lb
            // 
            this.val3_lb.AutoSize = true;
            this.val3_lb.Location = new System.Drawing.Point(12, 172);
            this.val3_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.val3_lb.Name = "val3_lb";
            this.val3_lb.Size = new System.Drawing.Size(41, 17);
            this.val3_lb.TabIndex = 70;
            this.val3_lb.Text = "\"val3\"";
            // 
            // val2_lb
            // 
            this.val2_lb.AutoSize = true;
            this.val2_lb.Location = new System.Drawing.Point(12, 140);
            this.val2_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.val2_lb.Name = "val2_lb";
            this.val2_lb.Size = new System.Drawing.Size(41, 17);
            this.val2_lb.TabIndex = 69;
            this.val2_lb.Text = "\"val2\"";
            // 
            // val1_lb
            // 
            this.val1_lb.AutoSize = true;
            this.val1_lb.Location = new System.Drawing.Point(12, 113);
            this.val1_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.val1_lb.Name = "val1_lb";
            this.val1_lb.Size = new System.Drawing.Size(41, 17);
            this.val1_lb.TabIndex = 68;
            this.val1_lb.Text = "\"val1\"";
            // 
            // routeip_lb
            // 
            this.routeip_lb.AutoSize = true;
            this.routeip_lb.Location = new System.Drawing.Point(12, 80);
            this.routeip_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.routeip_lb.Name = "routeip_lb";
            this.routeip_lb.Size = new System.Drawing.Size(65, 17);
            this.routeip_lb.TabIndex = 67;
            this.routeip_lb.Text = "\"route_ip\"";
            // 
            // sysip_lb
            // 
            this.sysip_lb.AutoSize = true;
            this.sysip_lb.Location = new System.Drawing.Point(12, 48);
            this.sysip_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sysip_lb.Name = "sysip_lb";
            this.sysip_lb.Size = new System.Drawing.Size(52, 17);
            this.sysip_lb.TabIndex = 66;
            this.sysip_lb.Text = "\"sys_ip\"";
            // 
            // val6_cb
            // 
            this.val6_cb.FormattingEnabled = true;
            this.val6_cb.Location = new System.Drawing.Point(115, 260);
            this.val6_cb.Margin = new System.Windows.Forms.Padding(2);
            this.val6_cb.Name = "val6_cb";
            this.val6_cb.Size = new System.Drawing.Size(270, 25);
            this.val6_cb.TabIndex = 65;
            // 
            // val5_cb
            // 
            this.val5_cb.FormattingEnabled = true;
            this.val5_cb.Location = new System.Drawing.Point(115, 229);
            this.val5_cb.Margin = new System.Windows.Forms.Padding(2);
            this.val5_cb.Name = "val5_cb";
            this.val5_cb.Size = new System.Drawing.Size(270, 25);
            this.val5_cb.TabIndex = 64;
            // 
            // val4_cb
            // 
            this.val4_cb.FormattingEnabled = true;
            this.val4_cb.Location = new System.Drawing.Point(115, 199);
            this.val4_cb.Margin = new System.Windows.Forms.Padding(2);
            this.val4_cb.Name = "val4_cb";
            this.val4_cb.Size = new System.Drawing.Size(270, 25);
            this.val4_cb.TabIndex = 63;
            // 
            // val3_cb
            // 
            this.val3_cb.FormattingEnabled = true;
            this.val3_cb.Location = new System.Drawing.Point(115, 169);
            this.val3_cb.Margin = new System.Windows.Forms.Padding(2);
            this.val3_cb.Name = "val3_cb";
            this.val3_cb.Size = new System.Drawing.Size(270, 25);
            this.val3_cb.TabIndex = 62;
            // 
            // val2_cb
            // 
            this.val2_cb.FormattingEnabled = true;
            this.val2_cb.Location = new System.Drawing.Point(115, 139);
            this.val2_cb.Margin = new System.Windows.Forms.Padding(2);
            this.val2_cb.Name = "val2_cb";
            this.val2_cb.Size = new System.Drawing.Size(270, 25);
            this.val2_cb.TabIndex = 61;
            // 
            // val1_cb
            // 
            this.val1_cb.FormattingEnabled = true;
            this.val1_cb.Location = new System.Drawing.Point(115, 108);
            this.val1_cb.Margin = new System.Windows.Forms.Padding(2);
            this.val1_cb.Name = "val1_cb";
            this.val1_cb.Size = new System.Drawing.Size(270, 25);
            this.val1_cb.TabIndex = 60;
            // 
            // val7_cb
            // 
            this.val7_cb.FormattingEnabled = true;
            this.val7_cb.Location = new System.Drawing.Point(115, 290);
            this.val7_cb.Margin = new System.Windows.Forms.Padding(2);
            this.val7_cb.Name = "val7_cb";
            this.val7_cb.Size = new System.Drawing.Size(270, 25);
            this.val7_cb.TabIndex = 59;
            // 
            // val8_cb
            // 
            this.val8_cb.FormattingEnabled = true;
            this.val8_cb.Location = new System.Drawing.Point(115, 320);
            this.val8_cb.Margin = new System.Windows.Forms.Padding(2);
            this.val8_cb.Name = "val8_cb";
            this.val8_cb.Size = new System.Drawing.Size(270, 25);
            this.val8_cb.TabIndex = 58;
            // 
            // routip_cb
            // 
            this.routip_cb.FormattingEnabled = true;
            this.routip_cb.Location = new System.Drawing.Point(115, 78);
            this.routip_cb.Margin = new System.Windows.Forms.Padding(2);
            this.routip_cb.Name = "routip_cb";
            this.routip_cb.Size = new System.Drawing.Size(270, 25);
            this.routip_cb.TabIndex = 57;
            // 
            // sysip_cb
            // 
            this.sysip_cb.FormattingEnabled = true;
            this.sysip_cb.Location = new System.Drawing.Point(115, 47);
            this.sysip_cb.Margin = new System.Windows.Forms.Padding(2);
            this.sysip_cb.Name = "sysip_cb";
            this.sysip_cb.Size = new System.Drawing.Size(270, 25);
            this.sysip_cb.TabIndex = 56;
            // 
            // Endline_lb
            // 
            this.Endline_lb.AutoSize = true;
            this.Endline_lb.Location = new System.Drawing.Point(298, 286);
            this.Endline_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Endline_lb.Name = "Endline_lb";
            this.Endline_lb.Size = new System.Drawing.Size(57, 17);
            this.Endline_lb.TabIndex = 25;
            this.Endline_lb.Text = "End Line";
            // 
            // Device_lb
            // 
            this.Device_lb.AutoSize = true;
            this.Device_lb.Location = new System.Drawing.Point(16, 286);
            this.Device_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Device_lb.Name = "Device_lb";
            this.Device_lb.Size = new System.Drawing.Size(37, 17);
            this.Device_lb.TabIndex = 24;
            this.Device_lb.Text = "Aygıt";
            // 
            // Endline_cb
            // 
            this.Endline_cb.FormattingEnabled = true;
            this.Endline_cb.Items.AddRange(new object[] {
            "null",
            "\\r",
            "\\n",
            "\\r\\n"});
            this.Endline_cb.Location = new System.Drawing.Point(373, 283);
            this.Endline_cb.Margin = new System.Windows.Forms.Padding(2);
            this.Endline_cb.Name = "Endline_cb";
            this.Endline_cb.Size = new System.Drawing.Size(74, 25);
            this.Endline_cb.TabIndex = 12;
            this.Endline_cb.SelectedIndexChanged += new System.EventHandler(this.Endline_cb_SelectedIndexChanged);
            // 
            // getway_set
            // 
            this.getway_set.Items.Add("8");
            this.getway_set.Items.Add("7");
            this.getway_set.Items.Add("6");
            this.getway_set.Items.Add("5");
            this.getway_set.Items.Add("4");
            this.getway_set.Items.Add("3");
            this.getway_set.Items.Add("2");
            this.getway_set.Items.Add("1");
            this.getway_set.Location = new System.Drawing.Point(393, 61);
            this.getway_set.Margin = new System.Windows.Forms.Padding(2);
            this.getway_set.Name = "getway_set";
            this.getway_set.Size = new System.Drawing.Size(54, 25);
            this.getway_set.TabIndex = 11;
            this.getway_set.SelectedItemChanged += new System.EventHandler(this.getway_set_SelectedItemChanged);
            // 
            // Devices_cb
            // 
            this.Devices_cb.FormattingEnabled = true;
            this.Devices_cb.Items.AddRange(new object[] {
            "ALCATEL (r)",
            "HUAWEI (n)",
            "ZTE  (n)",
            "Test1 (rn)",
            "Test2"});
            this.Devices_cb.Location = new System.Drawing.Point(119, 283);
            this.Devices_cb.Margin = new System.Windows.Forms.Padding(2);
            this.Devices_cb.Name = "Devices_cb";
            this.Devices_cb.Size = new System.Drawing.Size(167, 25);
            this.Devices_cb.TabIndex = 10;
            this.Devices_cb.SelectedIndexChanged += new System.EventHandler(this.Devices_cb_SelectedIndexChanged);
            // 
            // sysfound_cb
            // 
            this.sysfound_cb.FormattingEnabled = true;
            this.sysfound_cb.Location = new System.Drawing.Point(119, 222);
            this.sysfound_cb.Margin = new System.Windows.Forms.Padding(2);
            this.sysfound_cb.Name = "sysfound_cb";
            this.sysfound_cb.Size = new System.Drawing.Size(328, 25);
            this.sysfound_cb.TabIndex = 9;
            this.sysfound_cb.SelectedIndexChanged += new System.EventHandler(this.sysfound_cb_SelectedIndexChanged);
            // 
            // sysfound_lb
            // 
            this.sysfound_lb.AutoSize = true;
            this.sysfound_lb.Location = new System.Drawing.Point(16, 224);
            this.sysfound_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sysfound_lb.Name = "sysfound_lb";
            this.sysfound_lb.Size = new System.Drawing.Size(91, 17);
            this.sysfound_lb.TabIndex = 8;
            this.sysfound_lb.Text = "Sistem İsimleri";
            // 
            // IPsfound_cb
            // 
            this.IPsfound_cb.FormattingEnabled = true;
            this.IPsfound_cb.Location = new System.Drawing.Point(119, 184);
            this.IPsfound_cb.Margin = new System.Windows.Forms.Padding(2);
            this.IPsfound_cb.Name = "IPsfound_cb";
            this.IPsfound_cb.Size = new System.Drawing.Size(328, 25);
            this.IPsfound_cb.TabIndex = 7;
            this.IPsfound_cb.SelectedIndexChanged += new System.EventHandler(this.IPsfound_cb_SelectedIndexChanged);
            // 
            // IPsfound_lb
            // 
            this.IPsfound_lb.AutoSize = true;
            this.IPsfound_lb.Location = new System.Drawing.Point(16, 192);
            this.IPsfound_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IPsfound_lb.Name = "IPsfound_lb";
            this.IPsfound_lb.Size = new System.Drawing.Size(37, 17);
            this.IPsfound_lb.TabIndex = 6;
            this.IPsfound_lb.Text = "IP ler";
            // 
            // GetwayIP_tb
            // 
            this.GetwayIP_tb.Location = new System.Drawing.Point(119, 61);
            this.GetwayIP_tb.Margin = new System.Windows.Forms.Padding(2);
            this.GetwayIP_tb.Name = "GetwayIP_tb";
            this.GetwayIP_tb.Size = new System.Drawing.Size(270, 25);
            this.GetwayIP_tb.TabIndex = 5;
            // 
            // getwayIP
            // 
            this.getwayIP.AutoSize = true;
            this.getwayIP.Location = new System.Drawing.Point(16, 64);
            this.getwayIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.getwayIP.Name = "getwayIP";
            this.getwayIP.Size = new System.Drawing.Size(56, 17);
            this.getwayIP.TabIndex = 4;
            this.getwayIP.Text = "Route IP";
            // 
            // getsyslist_btn
            // 
            this.getsyslist_btn.Location = new System.Drawing.Point(19, 130);
            this.getsyslist_btn.Margin = new System.Windows.Forms.Padding(2);
            this.getsyslist_btn.Name = "getsyslist_btn";
            this.getsyslist_btn.Size = new System.Drawing.Size(429, 34);
            this.getsyslist_btn.TabIndex = 3;
            this.getsyslist_btn.Text = "Sistem Listesini Al (uygulamadizini\\config\\syslist.txt)";
            this.getsyslist_btn.UseVisualStyleBackColor = true;
            this.getsyslist_btn.Click += new System.EventHandler(this.getsyslist_btn_Click);
            // 
            // syslist_cb
            // 
            this.syslist_cb.FormattingEnabled = true;
            this.syslist_cb.Location = new System.Drawing.Point(19, 101);
            this.syslist_cb.Margin = new System.Windows.Forms.Padding(2);
            this.syslist_cb.Name = "syslist_cb";
            this.syslist_cb.Size = new System.Drawing.Size(429, 25);
            this.syslist_cb.TabIndex = 2;
            this.syslist_cb.SelectedIndexChanged += new System.EventHandler(this.syslist_cb_SelectedIndexChanged);
            this.syslist_cb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.syslist_cb_KeyDown);
            // 
            // sysIP_tb
            // 
            this.sysIP_tb.Location = new System.Drawing.Point(119, 31);
            this.sysIP_tb.Margin = new System.Windows.Forms.Padding(2);
            this.sysIP_tb.Name = "sysIP_tb";
            this.sysIP_tb.Size = new System.Drawing.Size(270, 25);
            this.sysIP_tb.TabIndex = 1;
            this.sysIP_tb.TextChanged += new System.EventHandler(this.sysIP_tb_TextChanged);
            this.sysIP_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sysIP_tb_KeyPress);
            // 
            // sysIP
            // 
            this.sysIP.AutoSize = true;
            this.sysIP.Location = new System.Drawing.Point(16, 34);
            this.sysIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sysIP.Name = "sysIP";
            this.sysIP.Size = new System.Drawing.Size(60, 17);
            this.sysIP.TabIndex = 0;
            this.sysIP.Text = "Sistem IP";
            // 
            // precommand_tab
            // 
            this.precommand_tab.Controls.Add(this.command_lbox);
            this.precommand_tab.Controls.Add(this.startcfg_btn);
            this.precommand_tab.Controls.Add(this.refreshfile_btn);
            this.precommand_tab.Controls.Add(this.FilePathBox);
            this.precommand_tab.Location = new System.Drawing.Point(4, 26);
            this.precommand_tab.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.precommand_tab.Name = "precommand_tab";
            this.precommand_tab.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.precommand_tab.Size = new System.Drawing.Size(457, 695);
            this.precommand_tab.TabIndex = 1;
            this.precommand_tab.Text = "Hazır Komutlar";
            this.precommand_tab.UseVisualStyleBackColor = true;
            // 
            // command_lbox
            // 
            this.command_lbox.AllowDrop = true;
            this.command_lbox.ContextMenuStrip = this.Commandlbox_MenuStrip;
            this.command_lbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.command_lbox.FormattingEnabled = true;
            this.command_lbox.ItemHeight = 17;
            this.command_lbox.Location = new System.Drawing.Point(4, 2);
            this.command_lbox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.command_lbox.Name = "command_lbox";
            this.command_lbox.ScrollAlwaysVisible = true;
            this.command_lbox.Size = new System.Drawing.Size(449, 602);
            this.command_lbox.TabIndex = 0;
            this.command_lbox.DragDrop += new System.Windows.Forms.DragEventHandler(this.command_lbox_DragDrop);
            this.command_lbox.DragEnter += new System.Windows.Forms.DragEventHandler(this.command_lbox_DragEnter);
            this.command_lbox.DoubleClick += new System.EventHandler(this.command_lbox_DoubleClick);
            this.command_lbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.command_lbox_KeyDown);
            // 
            // Commandlbox_MenuStrip
            // 
            this.Commandlbox_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autocfg_cmts,
            this.startselectedrown_cmstrip,
            this.Edit_command_cmts,
            this.saveascmd_cmts,
            this.savecmd_cmts,
            this.Replace_selected_row_cmts,
            this.insert_between_cmd_cmts,
            this.insertcmd_cmts,
            this.moveup_cmts,
            this.movedown_cmts});
            this.Commandlbox_MenuStrip.Name = "Commandlbox_MenuStrip";
            this.Commandlbox_MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Commandlbox_MenuStrip.Size = new System.Drawing.Size(299, 224);
            // 
            // autocfg_cmts
            // 
            this.autocfg_cmts.Name = "autocfg_cmts";
            this.autocfg_cmts.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.autocfg_cmts.Size = new System.Drawing.Size(298, 22);
            this.autocfg_cmts.Text = "Konfigürasyonu Başlat";
            this.autocfg_cmts.Click += new System.EventHandler(this.autocfg_cmts_Click);
            // 
            // startselectedrown_cmstrip
            // 
            this.startselectedrown_cmstrip.Name = "startselectedrown_cmstrip";
            this.startselectedrown_cmstrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.startselectedrown_cmstrip.Size = new System.Drawing.Size(298, 22);
            this.startselectedrown_cmstrip.Text = "Seçili Satırdan Başlat";
            this.startselectedrown_cmstrip.Click += new System.EventHandler(this.startselectedrown_cmstrip_Click);
            // 
            // Edit_command_cmts
            // 
            this.Edit_command_cmts.Name = "Edit_command_cmts";
            this.Edit_command_cmts.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.Edit_command_cmts.Size = new System.Drawing.Size(298, 22);
            this.Edit_command_cmts.Text = "Düzenle";
            this.Edit_command_cmts.Click += new System.EventHandler(this.Edit_command_cmts_Click);
            // 
            // saveascmd_cmts
            // 
            this.saveascmd_cmts.Name = "saveascmd_cmts";
            this.saveascmd_cmts.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveascmd_cmts.Size = new System.Drawing.Size(298, 22);
            this.saveascmd_cmts.Text = "Farklı Kaydet";
            this.saveascmd_cmts.Click += new System.EventHandler(this.saveascmd_cmts_Click);
            // 
            // savecmd_cmts
            // 
            this.savecmd_cmts.Name = "savecmd_cmts";
            this.savecmd_cmts.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.savecmd_cmts.Size = new System.Drawing.Size(298, 22);
            this.savecmd_cmts.Text = "Kaydet";
            this.savecmd_cmts.Click += new System.EventHandler(this.savecmd_cmts_Click);
            // 
            // Replace_selected_row_cmts
            // 
            this.Replace_selected_row_cmts.Name = "Replace_selected_row_cmts";
            this.Replace_selected_row_cmts.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.Replace_selected_row_cmts.Size = new System.Drawing.Size(298, 22);
            this.Replace_selected_row_cmts.Text = "Seçili Satırı Değiştir";
            this.Replace_selected_row_cmts.Click += new System.EventHandler(this.Replace_selected_row_cmts_Click);
            // 
            // insert_between_cmd_cmts
            // 
            this.insert_between_cmd_cmts.Name = "insert_between_cmd_cmts";
            this.insert_between_cmd_cmts.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.insert_between_cmd_cmts.Size = new System.Drawing.Size(298, 22);
            this.insert_between_cmd_cmts.Text = "Araya Komut Satırı Ekle";
            this.insert_between_cmd_cmts.Click += new System.EventHandler(this.insert_between_cmd_cmts_Click);
            // 
            // insertcmd_cmts
            // 
            this.insertcmd_cmts.Name = "insertcmd_cmts";
            this.insertcmd_cmts.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.insertcmd_cmts.Size = new System.Drawing.Size(298, 22);
            this.insertcmd_cmts.Text = "Komut Satırından Komut Ekle";
            this.insertcmd_cmts.Click += new System.EventHandler(this.insertcmd_cmts_Click);
            // 
            // moveup_cmts
            // 
            this.moveup_cmts.Name = "moveup_cmts";
            this.moveup_cmts.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.moveup_cmts.Size = new System.Drawing.Size(298, 22);
            this.moveup_cmts.Text = "Yukarı Taşı";
            this.moveup_cmts.Click += new System.EventHandler(this.moveup_cmts_Click);
            // 
            // movedown_cmts
            // 
            this.movedown_cmts.Name = "movedown_cmts";
            this.movedown_cmts.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.movedown_cmts.Size = new System.Drawing.Size(298, 22);
            this.movedown_cmts.Text = "Aşağı Taşı";
            this.movedown_cmts.Click += new System.EventHandler(this.movedown_cmts_Click);
            // 
            // startcfg_btn
            // 
            this.startcfg_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.startcfg_btn.Location = new System.Drawing.Point(4, 604);
            this.startcfg_btn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.startcfg_btn.Name = "startcfg_btn";
            this.startcfg_btn.Size = new System.Drawing.Size(449, 32);
            this.startcfg_btn.TabIndex = 3;
            this.startcfg_btn.Text = "Konfigürasyonu Başlat";
            this.startcfg_btn.UseVisualStyleBackColor = true;
            this.startcfg_btn.Click += new System.EventHandler(this.startcfg_btn_Click);
            // 
            // refreshfile_btn
            // 
            this.refreshfile_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.refreshfile_btn.Location = new System.Drawing.Point(4, 636);
            this.refreshfile_btn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.refreshfile_btn.Name = "refreshfile_btn";
            this.refreshfile_btn.Size = new System.Drawing.Size(449, 32);
            this.refreshfile_btn.TabIndex = 2;
            this.refreshfile_btn.Text = "Dosya Listesini Yenile ( uygulama_dizini\\config)";
            this.refreshfile_btn.UseVisualStyleBackColor = true;
            this.refreshfile_btn.Click += new System.EventHandler(this.refreshfile_btn_Click);
            // 
            // FilePathBox
            // 
            this.FilePathBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FilePathBox.FormattingEnabled = true;
            this.FilePathBox.Location = new System.Drawing.Point(4, 668);
            this.FilePathBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.FilePathBox.Name = "FilePathBox";
            this.FilePathBox.Size = new System.Drawing.Size(449, 25);
            this.FilePathBox.TabIndex = 1;
            this.FilePathBox.SelectedIndexChanged += new System.EventHandler(this.FilePathBox_SelectedIndexChanged);
            // 
            // Main_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 803);
            this.Controls.Add(this.CLIpanel);
            this.Controls.Add(this.setting_panel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Main_Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Port v2.0 beta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.CLIpanel.ResumeLayout(false);
            this.CLIpanel.PerformLayout();
            this.cmd_cb_menustrip.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.setting_panel.ResumeLayout(false);
            this.command_tabpanel.ResumeLayout(false);
            this.defines_tab.ResumeLayout(false);
            this.defines_tab.PerformLayout();
            this.define_gb.ResumeLayout(false);
            this.define_gb.PerformLayout();
            this.precommand_tab.ResumeLayout(false);
            this.Commandlbox_MenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem lang_tstripmenu;
        private System.Windows.Forms.ToolStripComboBox langs_tstrip_cb;
        private System.Windows.Forms.ToolStripMenuItem lang_tstripmenu1;
        private System.Windows.Forms.ToolStripComboBox langs_tstrip_cb1;
        private System.Windows.Forms.ToolStripMenuItem connectset_tsmn;
        private System.Windows.Forms.ToolStripMenuItem help_tsmn;
        private System.Windows.Forms.ToolStripMenuItem about_tsmn;
        private System.Windows.Forms.ToolStripMenuItem appdetail_tsmn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel CLIpanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel portlist_tslabel;
        private System.Windows.Forms.ToolStripComboBox portlist_tscb;
        private System.Windows.Forms.ToolStripButton connection_tsbtn;
        private System.Windows.Forms.Panel setting_panel;
        private System.Windows.Forms.ComboBox cmd_cb;
        private System.Windows.Forms.TextBox clitbox;
        private System.Windows.Forms.TabControl command_tabpanel;
        private System.Windows.Forms.TabPage defines_tab;
        private System.Windows.Forms.TabPage precommand_tab;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ListBox command_lbox;
        private System.Windows.Forms.Button refreshfile_btn;
        private System.Windows.Forms.ComboBox FilePathBox;
        private System.Windows.Forms.Button startcfg_btn;
        private System.Windows.Forms.ToolStripStatusLabel command_procces;
        private System.Windows.Forms.ToolStripProgressBar Autocfg_procces;
        private System.Windows.Forms.Label sysIP;
        private System.Windows.Forms.ComboBox syslist_cb;
        private System.Windows.Forms.TextBox sysIP_tb;
        private System.Windows.Forms.TextBox GetwayIP_tb;
        private System.Windows.Forms.Label getwayIP;
        private System.Windows.Forms.Button getsyslist_btn;
        private System.Windows.Forms.ComboBox sysfound_cb;
        private System.Windows.Forms.Label sysfound_lb;
        private System.Windows.Forms.ComboBox IPsfound_cb;
        private System.Windows.Forms.Label IPsfound_lb;
        private System.Windows.Forms.DomainUpDown getway_set;
        private System.Windows.Forms.ComboBox Devices_cb;
        private System.Windows.Forms.ComboBox Endline_cb;
        private System.Windows.Forms.Label Endline_lb;
        private System.Windows.Forms.Label Device_lb;
        private System.Windows.Forms.GroupBox define_gb;
        private System.Windows.Forms.Label val8_lb;
        private System.Windows.Forms.Label val7_lb;
        private System.Windows.Forms.Label val6_lb;
        private System.Windows.Forms.Label val5_lb;
        private System.Windows.Forms.Label val4_lb;
        private System.Windows.Forms.Label val3_lb;
        private System.Windows.Forms.Label val2_lb;
        private System.Windows.Forms.Label val1_lb;
        private System.Windows.Forms.Label routeip_lb;
        private System.Windows.Forms.Label sysip_lb;
        private System.Windows.Forms.ComboBox val6_cb;
        private System.Windows.Forms.ComboBox val5_cb;
        private System.Windows.Forms.ComboBox val4_cb;
        private System.Windows.Forms.ComboBox val3_cb;
        private System.Windows.Forms.ComboBox val2_cb;
        private System.Windows.Forms.ComboBox val1_cb;
        private System.Windows.Forms.ComboBox val7_cb;
        private System.Windows.Forms.ComboBox val8_cb;
        private System.Windows.Forms.ComboBox routip_cb;
        private System.Windows.Forms.ComboBox sysip_cb;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem baudrateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBitToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox databit_tscb;
        private System.Windows.Forms.ToolStripComboBox baudrate_tscb;
        private System.Windows.Forms.ToolStripMenuItem parityToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox parity_tscb;
        private System.Windows.Forms.ToolStripMenuItem stopBitToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox stopbit_tscb;
        private System.Windows.Forms.ToolStripMenuItem dTREnableToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox dtr_tscb;
        private System.Windows.Forms.ToolStripMenuItem portToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel sysip_tslb;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel sysname_tslb;
        private System.Windows.Forms.ContextMenuStrip Commandlbox_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem startselectedrown_cmstrip;
        private System.Windows.Forms.ToolStripMenuItem Edit_command_cmts;
        private System.Windows.Forms.ToolStripMenuItem insertcmd_cmts;
        private System.Windows.Forms.ToolStripMenuItem saveascmd_cmts;
        private System.Windows.Forms.ToolStripMenuItem savecmd_cmts;
        private System.Windows.Forms.ToolStripMenuItem autocfg_cmts;
        private System.Windows.Forms.ToolStripMenuItem Replace_selected_row_cmts;
        private System.Windows.Forms.ToolStripMenuItem insert_between_cmd_cmts;
        private System.Windows.Forms.ToolStripMenuItem moveup_cmts;
        private System.Windows.Forms.ToolStripMenuItem movedown_cmts;
        private System.Windows.Forms.ContextMenuStrip cmd_cb_menustrip;
        private System.Windows.Forms.ToolStripMenuItem save_cmd_cb_cmts;
        private System.Windows.Forms.ToolStripMenuItem replace_cmd_cb_cmts;
        private System.Windows.Forms.ToolStripMenuItem insert_selectedrow_cmd_cb_cmts;
        private System.Windows.Forms.ToolStripMenuItem insert_endline_cmd_cb_cmts;
        private System.Windows.Forms.ToolStripMenuItem templates_tsmn;
        private System.Windows.Forms.ToolStripMenuItem template_sample_tsmn;
        private System.Windows.Forms.ToolStripMenuItem define_template_tsmn;
        private System.Windows.Forms.ToolStripMenuItem syslist_template_tsmn;
        private System.Windows.Forms.ToolStripMenuItem nokiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem huaweiToolStripMenuItem;
    }
}

