using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metod3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //girilen sayının tek mi çift olduğunu bulan metod
            Console.Write("Tek Mi Çift Mi Bulmak İstediğiniz Sayı: ");
            int sayi4 = Convert.ToInt32(Console.ReadLine());
            tekMiCiftMi(sayi4);

            Console.ReadLine();
        }

        static void tekMiCiftMi(int sayi6)
        {
            if (sayi6 % 2 == 0)
            {
                Console.WriteLine(sayi6 + " Çift");
            }
            else if (sayi6 % 2 == 1)
            {
                Console.WriteLine(sayi6 + " Tek");
            }
            else
            {
                Console.WriteLine("Girilen Değeri Kontrol Edin.");
            }
        }
    }
}
