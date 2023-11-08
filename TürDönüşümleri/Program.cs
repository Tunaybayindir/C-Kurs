using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TürDönüşümleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // integeri byte çevirme
            int sayi = 1;
            byte b = (byte)sayi;
            Console.WriteLine(b.GetType());

            // stringi integeri çevirme
            string sayi1 = "1";
            string sayi2 = "2";
            Console.WriteLine(sayi1+sayi2);
            // ilk çevirme kuralı
            int c = int.Parse(sayi1);
            // 2. çevirme kuralı
            int d = Convert.ToInt32(sayi2);
            Console.WriteLine(c+d);

            // int veri tipinden string veri tipine dönüştürme
            int sayi3 = 5;
            int sayi4 = 6;
            // Dönüştürmeden 11 çünkü int toplanır string olunca yan yana yazar
            Console.WriteLine(sayi3+sayi4);
            // Dönüştürülünce 56 
            string bes = sayi3.ToString();
            string altı = sayi4.ToString();
            Console.WriteLine(bes+altı);

            //double dan inte çevirme
            double t = 5.22;
            Console.WriteLine(t.GetType());
            //inte çeviriyoruz
            int te = Convert.ToInt32(t);
            Console.WriteLine(te.GetType());

            // kullanıcıdan alınan değerler string gelir
            string kullanıcı_adı = Console.ReadLine();
            Console.WriteLine(kullanıcı_adı.GetType());
            int sayi10 = Convert.ToInt32(kullanıcı_adı);
            Console.WriteLine(sayi10.GetType());
            Console.ReadLine();

            // veri.ToString()
            // Convert.ToInt32(veri)
            // int.Parse(veri)
            // double.parse(veri)
            // (int)
        
        }
    }
}
