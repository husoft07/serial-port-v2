using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Serial_Port
{
    public static class defines
    {
        public static void sample_syslist()
        {
            // Kaydedilecek metin
            string textToSave = "SYSID (SUB_SYS1|SUB_SYS2|SUB_SYS3) [IP Address1|IP Address2|IP Address3]  parantez içerisindeki ayraçlar harf değildir. Alt Gr ile birlikte -_ işaretlerinin bulunduğu tuşa basınca çıkan karakterdir. Uygulamanın dosyayı alabilmesi için başındaki sample_ ifadesini kaldırıp test edebilir siniz.";

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
            // Kaydedilecek metin
            string textToSave = @"NOKIA
 7353 7363 sıfır kontrol kartlarında şifre ******* //güvenlik nedeni ile şifreleri sansürledim
ilk tanımdan sonra Şifre ******* olarak ayarlanıyor
isadmin
*******      	    //Kart sıfır ise varsayılan olarak bu şifre ile gelir
*******         	//Yeni şifre olarak bunu belirlemeniz gerekiyor
*******
configure system security snmp community public host-address 0.0.0.0/0
exit all
configure system management no default-route
configure system management host-ip-address manual:""sys_ip""/24
exit all
configure system management default-route ""route_ip"".254
configure ethernet autoneg nt:1 index 1 auto-neg ""Aneg""
configure system mgnt-vlan no cvlan
configure ethernet mau nt:1 index 1 mau-type ""C_type""
ping ""route_ip"".254 timeout 1000
exit all";

            // Uygulama dizininde config klasörünün yolu
            string configFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config");

            // config klasörünü oluştur (eğer yoksa)
            if (!Directory.Exists(configFolderPath))
            {
                Directory.CreateDirectory(configFolderPath);
            }

            // Dosya yolu
            string filePath = Path.Combine(configFolderPath, "sample_nokia 7353.txt");

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

        public static void sampleztecmd()
        {
            // Kaydedilecek metin
            string textToSave = @"ZTE
 9806H/V ip_route için dslam ip ilk 3 blok
Login:*****   Password:******* //güvenlik nedeni ile şifreleri sansürledim
*******
***********    //Kart yeni versiyon ve kullanılmış bir kart ise şifre bu belirleniyor
******           //Yeni versiyon ancak kullanılmamış bir kart ise şifre bu ancak yeni şifre belirlemede yukarıdaki şifre kullanılıyor
enable
*******. //şifre
erase configuration // kullanılmış kartlarda bazen silme işlemi gerekebilir. Sıfır kartlarda bu komutu kaldırabilirsiniz
configure
no ip route 0.0.0.0
no ip route 192.168.0.0
no ip route 81.212.90.0
no ip route 10.159.199.128
no ip route 10.159.199.0
no ip subnet
system vlan-mode tr101
add-vlan 4091
vlan 4091 5/1-2 tag     //ZTE 9806h/v şaselerde kontrol kartı için bu satır kullanılır
vlan 4091 3/1-2 tag     //ZTE T21 sistemlerde kontrol kartı için bu satır kullanılır.
ip subnet ""sys_ip"" 255.255.255.0 4091
ip route 192.168.0.0 255.255.0.0 ""route_ip"".1
ping ""route_ip"".1
exit
copy run start
show ip subnet
show ip route
show vlan 4091
logout
y";

            // Uygulama dizininde config klasörünün yolu
            string configFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config");

            // config klasörünü oluştur (eğer yoksa)
            if (!Directory.Exists(configFolderPath))
            {
                Directory.CreateDirectory(configFolderPath);
            }

            // Dosya yolu
            string filePath = Path.Combine(configFolderPath, "sample_zte.txt");

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

        public static void samplehuaweicmd()
        {

            // Kaydedilecek metin
            string textToSave = @"Huawei
 MA5616 MA5818 ilk 3 satır bilgi satırı
otomatik girişte dikkate alınmaz

********. //kullanıcı adı
********        //şifre değişiklik gösterebiliyor
**********        //şifre değişiklik gösterebiliyor bu ikisinden biri
y
enable
config
port mode 0/0/0 ge  //5622 T21 için
y                   //üst komutun devamı
interface eth 0/0
combo-mode 0 optic
y
auto-neg 0 ""autoneg""
quit
vlan 4000 standard
port vlan 4000 0/0 0
interface vlanif 4000
ip address ""sys_ip"" 24

quit
ping ""route_ip"".1
save        //bu komut ayarların kaydedilmesi içindir. Bu komut çalıştırılmadan sistem kapanırsa ayarlar sıfırlanır.
y
quit
quit
y
";

            // Uygulama dizininde config klasörünün yolu
            string configFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config");

            // config klasörünü oluştur (eğer yoksa)
            if (!Directory.Exists(configFolderPath))
            {
                Directory.CreateDirectory(configFolderPath);
            }

            // Dosya yolu
            string filePath = Path.Combine(configFolderPath, "sample_huawei.txt");

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


