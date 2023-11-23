using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dizi Tanımlama, Değer Atama ve Ekrana Yazdırma
            int[] sayilar = new int[4];
            sayilar[0] = 1;
            sayilar[1] = 2;
            sayilar[2] = 3;
            sayilar[3] = 4;

            for(int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            //string
            string[] isimler = { "Tunay", "ahmet", "ali" };
            for(int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }

            //char
            char[] karakter = { 'E', 'A' };
            for(int i = 0; i < karakter.Length; i++)
            {
                Console.WriteLine(karakter[i]);
            }

            //double
            double[] ondalikli_sayilar = { 1.44, 2.55, 3.53 };
            for(int i = 0; i < ondalikli_sayilar.Length; i++)
            {
                Console.WriteLine(ondalikli_sayilar[i]);
            }


            //Kullanıcıdan 4 değer alan ve ekrana yazdıran program
            Console.WriteLine("***********************************");
            int[] sayilarr = new int[4];
            for(int i =0; i < sayilarr.Length; i++)
            {
                Console.Write("Sayilar Dizisinin "+i+". indeksini Giriniz: ");
                sayilarr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("***********************************");
            for (int i= 0; i< sayilarr.Length; i++)
            {
                Console.WriteLine(sayilarr[i]);
            }
            Console.ReadLine();
        }
    }
}
