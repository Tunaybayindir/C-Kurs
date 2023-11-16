using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            selamVer();
            isimSoyle();
        }
        
        // metod tanımlıyoruz parametresiz
        static void selamVer()
        {
            Console.WriteLine("Selamlar:)))");
            
        }

        static  void isimSoyle()
        {
            Console.WriteLine("Tunay Bayındır");
            Console.ReadLine();
        }
    }
}
