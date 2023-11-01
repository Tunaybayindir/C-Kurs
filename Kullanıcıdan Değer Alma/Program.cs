using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kullanıcıdan_Değer_Alma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan Değer Alma

            Console.WriteLine("Ad: ");
            string ad = Console.ReadLine();

            Console.WriteLine("Soyad: ");
            string soyad = Console.ReadLine();

            Console.WriteLine("Adı= " + ad);
            Console.WriteLine("Soyadı= " + soyad);

            Console.ReadLine();
        }
    }
}
