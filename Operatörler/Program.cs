using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatörler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operatörler
            //Toplama
            int sayi1 = 56;
            int sayi2 = 7;
            int sayi3 = 3;
            Console.WriteLine(sayi1+sayi2);
            
            //çarpma
            Console.WriteLine(sayi1*sayi2);
            
            //bölme
            Console.WriteLine(sayi1/sayi2);
            
            //mod alma
            Console.WriteLine(sayi1%sayi3);
            
            //arttırma operatörü
            Console.WriteLine(sayi1);
            sayi1++;
            Console.WriteLine("Sayi1 azaltıldı.");
            Console.WriteLine(sayi1);
            
            //azaltma operatörü
            sayi3--;
            Console.WriteLine("Sayi3 Arttırıldı.");
            Console.WriteLine(sayi3);
            
            //eşittir
            int sayi4 = 5;
            int sayi5 = 6;
            bool kontrolEt = sayi4 == sayi5;
            Console.WriteLine(kontrolEt);

            //eşit değildir
            bool kontrolEt2 = sayi4 != sayi5;
            Console.WriteLine(kontrolEt2);

            //Büyüktür >
            //büyük ve eşittir >=
            int yas = 18;
            bool kontrolEt3 = yas > 18;
            bool kontrolEt4 = yas >= 18;
            Console.WriteLine("----------yas kontrol----------");
            Console.WriteLine(kontrolEt3);
            Console.WriteLine(kontrolEt4);

            //küçüktür <
            //küçüktür ve eşittir <=
            int yas1 = 19;
            bool kontrolEt5 = yas1 < 18;
            bool kontrolEt6 = yas1 <= 19;
            Console.WriteLine(kontrolEt5);
            Console.WriteLine(kontrolEt6);

            //& ve operatörü
            int sayi6 = 5;
            int sayi7 = 5;
            int sayi8 = 10;
            bool kontrolEt7 = sayi6 == sayi7 && sayi7 < sayi8;
            Console.WriteLine(kontrolEt7);
            Console.WriteLine("------------- veya operatörü ---------------");

            // || veya operatörü
            int sayi9 = 5;
            int sayi10 = 5;
            int sayi11 = 10;
            bool kontrolEt8 = sayi9 == sayi10 || sayi10 > sayi11;
            Console.WriteLine(kontrolEt8);
            Console.WriteLine("-------------- değil operatörü -------------------");

            // ! değil operatörü
            // var olan bir şeyi zıttına çevirir
            bool a = true;
            Console.WriteLine(!a);
            Console.WriteLine("------------- Ek Operatörler --------------------");

            // += -= /= *= ek operatörler
            int sayi12 = 15;
            sayi12 += 5;
            Console.WriteLine(sayi12);
            sayi12 -= 5;
            Console.WriteLine(sayi12);
            sayi12 /= 3;
            Console.WriteLine(sayi12);
            sayi12 *= 2;
            Console.WriteLine(sayi12);

            Console.ReadLine();
        }
    }
}
