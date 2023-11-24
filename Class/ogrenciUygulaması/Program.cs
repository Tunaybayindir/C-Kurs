using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciUygulaması1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;
            Ogrenci ogrenci = new Ogrenci("Tunay", "Bayındır", 2022113023, 80, 60, 100, "Akdeniz Universitesi");

            Console.WriteLine("Uygulamaya Hoşgeldiniz.");
            Console.WriteLine("Yapacağınız İşlemin Numarasını giriniz: ");
            islemleriGoster();
            while (kontrol)
            {
                Console.WriteLine("****************************");
                string islem = Console.ReadLine();
                switch (islem)
                {
                    case "1":
                        Console.WriteLine("****************************");
                        ogrenci.ogrenciBilgileriGoster();
                        Console.WriteLine("****************************");
                        break;
                    case "2":
                        Console.WriteLine("****************************");
                        double ogrenciOrtalama = ogrenci.ogrenciOrtalama();
                        Console.WriteLine("Ogrenci Ortalama: "+ogrenciOrtalama);
                        Console.WriteLine("****************************");
                        break;
                    case "3":
                        Console.WriteLine("****************************");
                        ogrenci.ogrenciOkulGoster();
                        Console.WriteLine("****************************");
                        break;
                    case "4":
                        kontrol = false;
                        Console.WriteLine("Program Kapatılıyor...");
                        break;
                    default:
                        break;
                }
            }

             void islemleriGoster()
            {
                Console.WriteLine("1- Öğrenci Bilgilerini Göster");
                Console.WriteLine("2- Ögrenci Ortalamasını Göster");
                Console.WriteLine("3- Öğrenci Okulunu Göster");
                Console.WriteLine("4- Çıkış Yap");
            }




            Console.ReadLine();

        }
    }
}
