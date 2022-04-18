using System;

namespace hata_yonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        { // bu özellikleri günlük hayatta şu şekilde kullanabiliriz. örneğin izden yaşınızı veya tarih soran bir uygulumada siz sayı yerine metinsel
            // bir ifade girdiniz veya boş bırakıp geçtinizz. bu formda aşşağıda uyarı mesajı çıkar. derki: blabla kısmı boş bırakılamaz veya geçersiz sayı girişi
            // bu tarz kontol mekanizmalarını bunları kullanarakta tanımlayabiliriz. (bunlar benim düşüncelerimdir. yanlış olabilir ama mantık olarak bana doğru geliyor.)
          
            //try
            //{
            //    Console.WriteLine("Bir sayı Giriniz! :"); //kullanıcı burada sayı değilde yazı girebilir.
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Girmiş olduğunuz sayi :" + sayi);
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine("HATA: " + ex.Message.ToString());
            //}
            //finally //opsiyonel bir kod bloğu. yazmak zorunda değiliz. en altta işlem tamamlandı yazısını verir sadece
            //{
            //    Console.Write("işlem tamalandı");
            //}
          


            /*
             *  --girdi olarak sayı verirsek--
             *  örneğin "3" verelim
             *  
                Bir sayı Giriniz! :
             -> 3
                Girmiş olduğunuz sayi :3
                işlem tamalandı

             */

            /*
             *  --girdi olarak yazı, metin verirsek--
             *  örneğin "goktug" verelim
             *  
                Bir sayı Giriniz! :
             -> goktug
                HATA: Input string was not in a correct format.
                işlem tamalandı
               
             */
            
            
            //--PARSE METHODU--//
            //STRİNGLERİ İNTEGERA DÖNÜŞTÜRMEK İÇİN KULLANIYORUZ
            try
            {
                //int a=int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex)
            {

                Console.WriteLine("boş değer girdiniz");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("ÇOK KÜÇÜK/BÜYÜK BİR DEĞER GİRDİNİZ.");
                Console.WriteLine(ex);
            }
        }
    }
}
 