using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicvePrivateErisimBelirleyiciler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Public -- Private -- Protected -- internal
            Musteri musteri = new Musteri(20);

            musteri.isim = "tunay";
            musteri.soyisim = "bayındır";
            musteri.maasDegeri = 150000;
            musteri.cinsiyet = "Erkek";

            //yas private olduğu için alamıyoruz sadece sınıf içerisinde alabiliyoruz değerleri
            musteri.musteriBilgileriGoster();

            Console.ReadLine();
        }
    }
}
