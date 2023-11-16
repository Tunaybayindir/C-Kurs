using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metod2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            topla(2, 3);
            //girilen sayının karesini alan metodu yazıyoruz
            Console.Write("Karesini Almak İstediğiniz Sayıyı Giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            kareAl(sayi1);

            //girilen 2 sayıdan büyük olanı yazdıran metod
            Console.Write("1. Sayı: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayı: ");
            int sayi3 = Convert.ToInt32(Console.ReadLine());
            hangiBuyuk(sayi2, sayi3);

            Console.ReadLine();
        }

        //aşağıdaki metoda parametre verdik 2 tane
        static void topla(int sayi1 , int sayi2)
        {
            Console.WriteLine("Toplam: "+(sayi1+sayi2));
        }

        static void kareAl(int sayi3)
        {
            int sonuc = sayi3 * sayi3;
            Console.WriteLine(sayi3 +" karesi: "+sonuc);
        }
        static void hangiBuyuk(int sayi4, int sayi5)
        {
            if (sayi4 > sayi5)
            {
                Console.WriteLine(sayi4+" > "+sayi5);
            }else if(sayi4 == sayi5)
            {
                Console.WriteLine("Sayılar Eşittir.");
            }else if (sayi5 > sayi4)
            {
                Console.WriteLine(sayi5+" > "+sayi4);
            }

            Console.WriteLine("Girilen Sayılar: "+sayi4 +", "+ sayi5);
        }
        
    }
}
