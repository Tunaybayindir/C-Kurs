using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayiBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 1, 1, 2, 3, 4, 5, 6, 10, 20, 10, 20, 30, 40, 50, 50, 60, 60, 70, 80 };
            int adet = 0;
            int sayi;

            Console.Write("Aratmak İstediğiniz Sayıyı Giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] == sayi)
                {
                    adet++;
                }
            }
            if (adet == 0)
            {
                Console.WriteLine("Girdiginiz Sayı Listede Yok. ");
            }
            if(adet > 1)
            {
                Console.WriteLine("Girdiginiz Sayı Listede Var. ");
                Console.WriteLine("Adet: "+adet);
            }

            Console.ReadLine();
        }
    }
}
