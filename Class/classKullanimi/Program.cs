using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Araba.cs programında yazdığımız kodları burada nasıl çalıştırırız
            //Araba araba1 = new Araba();

            Araba araba1 = new Araba(4,"Hyundai","Kırmızı");

            //araba1.kapiSayisi = 4;
            //araba1.arabaRengi = "Kırmızı";
            //araba1.arabaModel = "Hyundai";

            araba1.arabaKilitle();
            araba1.motorCalistir();
            Console.WriteLine("Kapı Sayısı: "+araba1.kapiSayisi);
            Console.WriteLine("Araba Rengi: "+araba1.arabaRengi);
            Console.WriteLine("Araba Model: "+araba1.arabaModel);

            Console.ReadLine();
        }
    }
}
