using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notHesaplamaGelişmiş
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 3 tane not alan ve bu notların ortalamasını bulan ve ortalaması
            // eğer 80-100 arasındaysa A+ yazdır
            // 60-80 A 
            // 40-60 B+
            // 40dan küçükse F

            Console.WriteLine("1. Sınav Notunu Giriniz: ");
            int sinav1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2. Sınav Notunu Giriniz: ");
            int sinav2 = int.Parse(Console.ReadLine());
            Console.WriteLine("3. Sınav Notunu Giriniz: ");
            int sinav3 = int.Parse(Console.ReadLine());

            int ortalama = (sinav1 + sinav2 + sinav3) / 3;
            if (ortalama >= 80 && ortalama <= 100) 
            {
                Console.WriteLine("A+");
                Console.ReadLine();
            }
            else if (ortalama >= 60 && ortalama < 80) 
            {
                Console.WriteLine("A");
                Console.ReadLine();

            }
            else if (ortalama >=40 && ortalama < 60)
            {
                Console.WriteLine("B+"); 
                Console.ReadLine();

            }
            else if (ortalama >0 && ortalama <40)
            {
                Console.WriteLine("F");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Geçersiz Not Girişi Yaptınız.");
                Console.ReadLine();
            }
        }
    }
}
