using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bedenKitleHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Beden Kitle Endeksi = Kilo / boy*boy
            // Beden Kitle İndexi 18'e eşit veya düşükse ZAYIF
            // 18 ile 25 arasındaysa NORMAL
            // 25'ten büyükse OBEZ Yazdırılacak
            Console.WriteLine("Kilonuzu Giriniz: ");
            int kilo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Boyunuzu Giriniz: ");
            double boy = Convert.ToDouble(Console.ReadLine());
            
            double bye = kilo / (boy * boy);
            Console.WriteLine(bye);
            if (bye >= 25)
            {
                Console.WriteLine("OBEZ");
                Console.ReadLine();
            }
            else if (bye > 18 && bye < 25)
            {
                Console.WriteLine("NORMAL");
                Console.ReadLine();
            }
            else if(bye <=18)
            {
                Console.WriteLine("ZAYIF");
                Console.WriteLine("Kilo Al İBNE");
                Console.ReadLine();
            }

        }
    }
}
