using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicvePrivateErisimBelirleyiciler
{
    public class Musteri
    {
        public string isim;
        public string soyisim;
        public int maasDegeri;
        public string cinsiyet;
        //private
        private int yas;
        //yas private olduğu için yapıcı metod içerisinde tanımladık sınıf dışarısında tanımlanmıyor.
        public Musteri(int _yas)
        {
            yas = _yas;
        }


        //metod tanımlıyoruz
        //değer döndermeyen metod
        //public metod
        public void musteriBilgileriGoster()
        {
            Console.WriteLine("İsmi: "+isim);
            Console.WriteLine("Soyisim: "+soyisim);
            Console.WriteLine("Yas: "+yas);
            Console.WriteLine("Maaş: "+maasDegeri);
            Console.WriteLine("Cinsiyet: "+cinsiyet);
        }

        //2. metod tanımlıyoruz private olarak
        private void isimSoyisimYazdir(string isim, string soyisim)
        {
            Console.WriteLine("Müşterinin İsim ve Soyismi: "+isim+" "+soyisim);
        }
    }
}
