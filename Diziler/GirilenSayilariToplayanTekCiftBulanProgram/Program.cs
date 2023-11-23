using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirilenSayilariToplayanTekCiftBulanProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 10 tane int değer alan ve şunları yapan programı kodlayınız...
            // 1- Kaç adet tek , çift eleman olduğunu
            // 2- Çift değerlerin toplamını , Tek değerlerin toplamını
            // 3- Son olarak kontrol yapsın Çift değerlerin toplamı tek değerlerden büyükse Çift değerlerin toplamı büyüktür yazdırsın.
            // eğer teklerin toplamı büyükse => tek değerlerin toplamı büyüktür yazdırsın ...


            int[] sayilar = new int[10];

            int tekAdetToplam = 0;
            int ciftAdetToplam = 0;

            int tekSayilarinToplami = 0;
            int ciftSayilarinToplami = 0;

            int kullaniciDeger;

            for(int i =0; i < sayilar.Length; i++)
            {
                Console.Write((i+1)+". Sayıyı Giriniz: ");
                kullaniciDeger = int.Parse(Console.ReadLine());
                sayilar[i] = kullaniciDeger;
            }
            for(int j = 0; j < sayilar.Length; j++)
            {
                if (sayilar[j] %2==0)
                {
                    ciftAdetToplam ++;
                    ciftSayilarinToplami += sayilar[j];
                }
                else
                {
                    tekAdetToplam ++;
                    tekSayilarinToplami += sayilar[j];
                }
            }
            

            if (ciftSayilarinToplami > tekSayilarinToplami)
            {
                Console.WriteLine("Çift Sayılarin Toplamı Tek sayiların toplamından Büyüktür");
            }

            else
            {
                Console.WriteLine("Tek Sayılarin Toplamı Çift Sayilarin Toplamından Büyüktür");
            }

            Console.WriteLine("*********************************");

            Console.WriteLine("Çift Sayilarin Toplamı :" + ciftSayilarinToplami);
            Console.WriteLine("Çift Sayilarin Adedi : " + ciftAdetToplam);


            Console.WriteLine("*********************************");

            Console.WriteLine("Tek Sayilarin Toplamı :" + tekSayilarinToplami);
            Console.WriteLine("Tek Sayilarin Adedi :" + tekAdetToplam);

            Console.ReadLine();


        }
    }
}
