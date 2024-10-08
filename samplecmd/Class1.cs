using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace samplecmd
{
    public class MenuHelper
    {

       
        public static void CreateSampleMenu(MenuStrip menuStrip)
        {
            // Oluşturulan menüyü MenuStrip'e ekleme
            ToolStripMenuItem mainmenu = new ToolStripMenuItem("Custom area");
            menuStrip.Items.Add(mainmenu);

            // İç içe açılır menüler oluşturuluyor: Nokia, Huawei, ZTE
            ToolStripMenuItem Mymenu = new ToolStripMenuItem("Mymenu1");
            ToolStripMenuItem Mymenu2 = new ToolStripMenuItem("Mymenu2");
            ToolStripMenuItem Mymenu3 = new ToolStripMenuItem("Mymenu3");
            ToolStripMenuItem Other = new ToolStripMenuItem("Other");

            // "7353isam" adında bir alt menü öğesi oluşturuluyor
            ToolStripMenuItem submenu1 = new ToolStripMenuItem("submenu1");
            ToolStripMenuItem submenu2 = new ToolStripMenuItem("submenu2");
            ToolStripMenuItem submenu3 = new ToolStripMenuItem("submenu3");
            ToolStripMenuItem submenu4 = new ToolStripMenuItem("submenu4");
            ToolStripMenuItem submenu5 = new ToolStripMenuItem("submenu5");
            ToolStripMenuItem submenu6 = new ToolStripMenuItem("submenu6");

            // Nokia menüsüne "7353isam" alt menüsü ekleniyor
            Mymenu.DropDownItems.Add(submenu1);
            Mymenu.DropDownItems.Add(submenu2);
            Mymenu2.DropDownItems.Add(submenu3);
            Mymenu2.DropDownItems.Add(submenu4);
            Mymenu3.DropDownItems.Add(submenu5);
            Mymenu3.DropDownItems.Add(submenu6);
            //isamMenuHUA566165818.DropDownItems.Add(pingmenu);


            // Nokia, Huawei ve ZTE menü öğelerine tıklama olayları ekleniyor
            submenu1.Click += Submenu1_Click;
            submenu2.Click += Submenu2_Click;
            submenu3.Click += Submenu3_Click;
            submenu4.Click += Submenu4_Click;
            submenu5.Click += Submenu5_Click;
            submenu6.Click += Submenu6_Click;
            Other.Click += Other_Click;

            // Ana menüye bu üç alt menü ekleniyor
            mainmenu.DropDownItems.Add(Mymenu);
            mainmenu.DropDownItems.Add(Mymenu2);
            mainmenu.DropDownItems.Add(Mymenu3);
            mainmenu.DropDownItems.Add(Other);
        }
  

        private static void Other_Click(object sender, EventArgs e)
        {
            string textToSave = @"Tr = Bu kod alanını kurum yada kullanımınıza göre yapılandırabilirsiniz.
Kurum yada kullanımınızda hassa bilgilerin yer alması ihtimaline karşın bu menüyü ayrı bir kütüphane 
olarak tasarladım ve uygulamanın ana yapısını bozmadan sadece kütüphaneyi yapılandırıp kullanıcılarınıza dağıtabilirsiniz.
Uygulama dizininde bulunan samplecmd.dll dosyası bunun içindir.

En = You can configure this code area according to your institution or use.

I designed this menu as a separate library in case your institution or use 
contains sensitive information, and you can configure the library and distribute 
it to your users without disrupting the main structure of the application.

The samplecmd.dll file in the application directory is for this.";

            // Uygulama dizininde config klasörünün yolu
            string configFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config");

            // config klasörünü oluştur (eğer yoksa)
            if (!Directory.Exists(configFolderPath))
            {
                Directory.CreateDirectory(configFolderPath);
            }

            // Dosya yolu
            string filePath = Path.Combine(configFolderPath, "sample_other.txt");

            // Metni dosyaya yaz
            File.WriteAllText(filePath, textToSave);

            // Uyarı penceresi göster
            DialogResult result = MessageBox.Show($"Dosya kaydedildi: {filePath}\nDosyayı Notepad ile açmak ister misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            // Eğer kullanıcı dosyayı açmak isterse Notepad ile aç
            if (result == DialogResult.Yes)
            {
                Process.Start("notepad.exe", filePath);
            }
        }

        private static void Submenu6_Click(object sender, EventArgs e)
        {
            string textToSave = @"Tr = Bu kod alanını kurum yada kullanımınıza göre yapılandırabilirsiniz.
Kurum yada kullanımınızda hassa bilgilerin yer alması ihtimaline karşın bu menüyü ayrı bir kütüphane 
olarak tasarladım ve uygulamanın ana yapısını bozmadan sadece kütüphaneyi yapılandırıp kullanıcılarınıza dağıtabilirsiniz.
Uygulama dizininde bulunan samplecmd.dll dosyası bunun içindir.

En = You can configure this code area according to your institution or use.

I designed this menu as a separate library in case your institution or use 
contains sensitive information, and you can configure the library and distribute 
it to your users without disrupting the main structure of the application.

The samplecmd.dll file in the application directory is for this.";

            // Uygulama dizininde config klasörünün yolu
            string configFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config");

            // config klasörünü oluştur (eğer yoksa)
            if (!Directory.Exists(configFolderPath))
            {
                Directory.CreateDirectory(configFolderPath);
            }

            // Dosya yolu
            string filePath = Path.Combine(configFolderPath, "sample_submenu6.txt");

            // Metni dosyaya yaz
            File.WriteAllText(filePath, textToSave);

            // Uyarı penceresi göster
            DialogResult result = MessageBox.Show($"Dosya kaydedildi: {filePath}\nDosyayı Notepad ile açmak ister misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            // Eğer kullanıcı dosyayı açmak isterse Notepad ile aç
            if (result == DialogResult.Yes)
            {
                Process.Start("notepad.exe", filePath);
            }
        }

        private static void Submenu5_Click(object sender, EventArgs e)
        {
            string textToSave = @"Tr = Bu kod alanını kurum yada kullanımınıza göre yapılandırabilirsiniz.
Kurum yada kullanımınızda hassa bilgilerin yer alması ihtimaline karşın bu menüyü ayrı bir kütüphane 
olarak tasarladım ve uygulamanın ana yapısını bozmadan sadece kütüphaneyi yapılandırıp kullanıcılarınıza dağıtabilirsiniz.
Uygulama dizininde bulunan samplecmd.dll dosyası bunun içindir.

En = You can configure this code area according to your institution or use.

I designed this menu as a separate library in case your institution or use 
contains sensitive information, and you can configure the library and distribute 
it to your users without disrupting the main structure of the application.

The samplecmd.dll file in the application directory is for this.";

            // Uygulama dizininde config klasörünün yolu
            string configFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config");

            // config klasörünü oluştur (eğer yoksa)
            if (!Directory.Exists(configFolderPath))
            {
                Directory.CreateDirectory(configFolderPath);
            }

            // Dosya yolu
            string filePath = Path.Combine(configFolderPath, "sample_submenu5.txt");

            // Metni dosyaya yaz
            File.WriteAllText(filePath, textToSave);

            // Uyarı penceresi göster
            DialogResult result = MessageBox.Show($"Dosya kaydedildi: {filePath}\nDosyayı Notepad ile açmak ister misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            // Eğer kullanıcı dosyayı açmak isterse Notepad ile aç
            if (result == DialogResult.Yes)
            {
                Process.Start("notepad.exe", filePath);
            }
        }

        private static void Submenu4_Click(object sender, EventArgs e)
        {
            string textToSave = @"Tr = Bu kod alanını kurum yada kullanımınıza göre yapılandırabilirsiniz.
Kurum yada kullanımınızda hassa bilgilerin yer alması ihtimaline karşın bu menüyü ayrı bir kütüphane 
olarak tasarladım ve uygulamanın ana yapısını bozmadan sadece kütüphaneyi yapılandırıp kullanıcılarınıza dağıtabilirsiniz.
Uygulama dizininde bulunan samplecmd.dll dosyası bunun içindir.

En = You can configure this code area according to your institution or use.

I designed this menu as a separate library in case your institution or use 
contains sensitive information, and you can configure the library and distribute 
it to your users without disrupting the main structure of the application.

The samplecmd.dll file in the application directory is for this.";

            // Uygulama dizininde config klasörünün yolu
            string configFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config");

            // config klasörünü oluştur (eğer yoksa)
            if (!Directory.Exists(configFolderPath))
            {
                Directory.CreateDirectory(configFolderPath);
            }

            // Dosya yolu
            string filePath = Path.Combine(configFolderPath, "sample_submenu4.txt");

            // Metni dosyaya yaz
            File.WriteAllText(filePath, textToSave);

            // Uyarı penceresi göster
            DialogResult result = MessageBox.Show($"Dosya kaydedildi: {filePath}\nDosyayı Notepad ile açmak ister misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            // Eğer kullanıcı dosyayı açmak isterse Notepad ile aç
            if (result == DialogResult.Yes)
            {
                Process.Start("notepad.exe", filePath);
            }
        }

        private static void Submenu3_Click(object sender, EventArgs e)
        {
            string textToSave = @"Tr = Bu kod alanını kurum yada kullanımınıza göre yapılandırabilirsiniz.
Kurum yada kullanımınızda hassa bilgilerin yer alması ihtimaline karşın bu menüyü ayrı bir kütüphane 
olarak tasarladım ve uygulamanın ana yapısını bozmadan sadece kütüphaneyi yapılandırıp kullanıcılarınıza dağıtabilirsiniz.
Uygulama dizininde bulunan samplecmd.dll dosyası bunun içindir.

En = You can configure this code area according to your institution or use.

I designed this menu as a separate library in case your institution or use 
contains sensitive information, and you can configure the library and distribute 
it to your users without disrupting the main structure of the application.

The samplecmd.dll file in the application directory is for this.";

            // Uygulama dizininde config klasörünün yolu
            string configFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config");

            // config klasörünü oluştur (eğer yoksa)
            if (!Directory.Exists(configFolderPath))
            {
                Directory.CreateDirectory(configFolderPath);
            }

            // Dosya yolu
            string filePath = Path.Combine(configFolderPath, "sample_submenu3.txt");

            // Metni dosyaya yaz
            File.WriteAllText(filePath, textToSave);

            // Uyarı penceresi göster
            DialogResult result = MessageBox.Show($"Dosya kaydedildi: {filePath}\nDosyayı Notepad ile açmak ister misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            // Eğer kullanıcı dosyayı açmak isterse Notepad ile aç
            if (result == DialogResult.Yes)
            {
                Process.Start("notepad.exe", filePath);
            }
        }

        private static void Submenu2_Click(object sender, EventArgs e)
        {
            string textToSave = @"Tr = Bu kod alanını kurum yada kullanımınıza göre yapılandırabilirsiniz.
Kurum yada kullanımınızda hassa bilgilerin yer alması ihtimaline karşın bu menüyü ayrı bir kütüphane 
olarak tasarladım ve uygulamanın ana yapısını bozmadan sadece kütüphaneyi yapılandırıp kullanıcılarınıza dağıtabilirsiniz.
Uygulama dizininde bulunan samplecmd.dll dosyası bunun içindir.

En = You can configure this code area according to your institution or use.

I designed this menu as a separate library in case your institution or use 
contains sensitive information, and you can configure the library and distribute 
it to your users without disrupting the main structure of the application.

The samplecmd.dll file in the application directory is for this.";

            // Uygulama dizininde config klasörünün yolu
            string configFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config");

            // config klasörünü oluştur (eğer yoksa)
            if (!Directory.Exists(configFolderPath))
            {
                Directory.CreateDirectory(configFolderPath);
            }

            // Dosya yolu
            string filePath = Path.Combine(configFolderPath, "sample_submenu2.txt");

            // Metni dosyaya yaz
            File.WriteAllText(filePath, textToSave);

            // Uyarı penceresi göster
            DialogResult result = MessageBox.Show($"Dosya kaydedildi: {filePath}\nDosyayı Notepad ile açmak ister misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            // Eğer kullanıcı dosyayı açmak isterse Notepad ile aç
            if (result == DialogResult.Yes)
            {
                Process.Start("notepad.exe", filePath);
            }
        }

        private static void Submenu1_Click(object sender, EventArgs e)
        {
            string textToSave = @"Tr = Bu kod alanını kurum yada kullanımınıza göre yapılandırabilirsiniz.
Kurum yada kullanımınızda hassa bilgilerin yer alması ihtimaline karşın bu menüyü ayrı bir kütüphane 
olarak tasarladım ve uygulamanın ana yapısını bozmadan sadece kütüphaneyi yapılandırıp kullanıcılarınıza dağıtabilirsiniz.
Uygulama dizininde bulunan samplecmd.dll dosyası bunun içindir.

En = You can configure this code area according to your institution or use.

I designed this menu as a separate library in case your institution or use 
contains sensitive information, and you can configure the library and distribute 
it to your users without disrupting the main structure of the application.

The samplecmd.dll file in the application directory is for this.";

            // Uygulama dizininde config klasörünün yolu
            string configFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config");

            // config klasörünü oluştur (eğer yoksa)
            if (!Directory.Exists(configFolderPath))
            {
                Directory.CreateDirectory(configFolderPath);
            }

            // Dosya yolu
            string filePath = Path.Combine(configFolderPath, "sample_submenu1.txt");

            // Metni dosyaya yaz
            File.WriteAllText(filePath, textToSave);

            // Uyarı penceresi göster
            DialogResult result = MessageBox.Show($"Dosya kaydedildi: {filePath}\nDosyayı Notepad ile açmak ister misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            // Eğer kullanıcı dosyayı açmak isterse Notepad ile aç
            if (result == DialogResult.Yes)
            {
                Process.Start("notepad.exe", filePath);
            }
        }

     
    }
}
