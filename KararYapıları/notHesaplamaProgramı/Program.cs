using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notHesaplamaProgramı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Öğrencinin notu 50 den büyükse başarılı değilse başarısız yazdıran program

            int not = 50;

            if(not>50)
            {
                Console.WriteLine("Kayıt Başarılı");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Kayıt Başarısız Tekrar Deneyiniz");
                Console.ReadLine();
            }
        }
    }
}
