using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Serial_Port
{
    public class defines
    {
        public static void sample_syslist()
        {
            // Kaydedilecek metin
            string textToSave = "SYSID (SUB_SYS1|SUB_SYS2|SUB_SYS3) [IP Address1|IP Address2|IP Address3]  parantez içerisindeki ayraçlar hrf değildir. Alt Gr ile birlikte -_ işaretlerinin bulunduğu tuşa basınca çıkan karakterdir. Uygulamanın dosyayı alabilmesi için başındaki sample_ ifadesini kaldırıp test edebilir siniz.";

            // Uygulama dizininde config klasörünün yolu
            string configFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "defines");

            // config klasörünü oluştur (eğer yoksa)
            if (!Directory.Exists(configFolderPath))
            {
                Directory.CreateDirectory(configFolderPath);
            }

            // Dosya yolu
            string filePath = Path.Combine(configFolderPath, "sample_syslist.txt");

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

        public static void sample_defines() 
        {
            // Kaydedilecek metin
            string textToSave = @"
data.txt dosyanız silindiyse sample_ ifadesini dosya adından silip kaydedin.
bileşen_adı=bileşenin_uygulamada_görünecek_adı|bileşen>için>gereken>değerler|varsayılan olarak hangi değerin seçili olacağı.
val1_lb=""test1""|1>2>3>4|1
val2_lb=""test2""|a>b>c>d|2
val3_lb=""autoneg""|enable>disable|0
val4_lb=""c_type""|1000basetft>100basetxt|0
val5_lb=""c_type2""|electric>optic>automatic|1
val6_lb=""test6""|1>2>3>9|3
val7_lb=""test7""|1>2>3>10|2
val8_lb=""test8""|1>2>3>11|1";

            // Uygulama dizininde config klasörünün yolu
            string configFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "defines");

            // config klasörünü oluştur (eğer yoksa)
            if (!Directory.Exists(configFolderPath))
            {
                Directory.CreateDirectory(configFolderPath);
            }

            // Dosya yolu
            string filePath = Path.Combine(configFolderPath, "sample_data.txt");

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

        public static void samplenokiacmd()
        {
            MessageBox.Show("Güvenlik nedeni ile samplecmd.dll kütüphanesi ile bu menüyü farklı bir kütüphaneye taşıdım");

        }

        public static void sampleztecmd()
        {
            MessageBox.Show("Güvenlik nedeni ile samplecmd.dll kütüphanesi ile bu menüyü farklı bir kütüphaneye taşıdım");
           
        }

        public static void samplehuaweicmd()
        {

            MessageBox.Show("Güvenlik nedeni ile samplecmd.dll kütüphanesi ile bu menüyü farklı bir kütüphaneye taşıdım");


        }


    }
}


