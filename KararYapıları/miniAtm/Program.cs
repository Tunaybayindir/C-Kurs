using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniAtm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 1000;
            //Kullanıcıya ne işlem yapacağını soracağız
            //1- bakiye Görüntüleme
            //2- para çekme
            //3- para yatırma
            //q- basarsa çıkış yapar
            Console.WriteLine("Atm'ye Hoş Geldiniz");
            Console.WriteLine("Yapmak İstediğiniz işlemi seçiniz ");
            string secim = Console.ReadLine();
            if (secim == "1")
            {
                Console.WriteLine(bakiye+"TL");
                Console.ReadLine();
            }
            // Çekme İşlemi
            else if (secim == "2")
            {
                Console.WriteLine("Çekeceğiniz Miktarı Giriniz: ");
                int cekilecek_miktar = int.Parse(Console.ReadLine());
                if(cekilecek_miktar<=bakiye && cekilecek_miktar>0)
                {
                    bakiye = bakiye - cekilecek_miktar;
                    Console.WriteLine("Kalan Bakiyeniz:" + bakiye + "TL"); 
                    Console.ReadLine();


                }
                else if(cekilecek_miktar < 0)
                {
                    Console.WriteLine("0 dan büyük değer giriniz.");
                    Console.ReadLine();
                }
                else if(cekilecek_miktar>bakiye)
                {
                    Console.WriteLine("Çekilecek Miktar Bakiyeden Yüksek Olamaz");
                    Console.WriteLine("Tekrar Deneyiniz.");
                    Console.WriteLine("Çıkış Yapılıyor.");
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Geçerli Miktar Giriniz."); 
                    Console.WriteLine("Çıkış Yapılıyor.");

                }
            }
            // Yatırma İşlemi
            else if (secim == "3")
            {
                Console.WriteLine("Yatıracağınız Miktarı Giriniz: ");
                int yatirilacak_miktar = int.Parse(Console.ReadLine());
                if(yatirilacak_miktar>0)
                {
                    bakiye = bakiye + yatirilacak_miktar;
                    Console.WriteLine("Bakiye: " + bakiye + "TL");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Girilen Değer 0 dan büyük olmalı.");
                    Console.ReadLine();
                }
                
            }
            else if (secim == "q")
            {
                Console.WriteLine("Çıkış Yapılıyor.");
                Console.WriteLine("Çıkış Yapıldı iyi günler...");
            }
            else
            {
                Console.WriteLine("Geçerli İşlem Giriniz. ");
                Console.ReadLine();
            }
        }
    }
}
