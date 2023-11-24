using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classKullanimi
{
    internal class Araba
    {
        public int kapiSayisi;
        public string arabaModel;
        public string arabaRengi;

        public Araba(int _kapiSayisi, string _arabaModel, string _arabaRengi)
        {
            //Console.WriteLine("Araba Sınıfının Yapıcı Metodu Çalıştı.");
            kapiSayisi = _kapiSayisi;
            arabaModel = _arabaModel;
            arabaRengi = _arabaRengi; //_arabaRengi yukarıdan alıyor //arabaRengi en yukarıda tanımladığımız yer
        }

        public void motorCalistir()
        {
            Console.WriteLine("Motor Çalıştırılıyor...");
        }
        public void arabaKilitle()
        {
            Console.WriteLine("Araba Kilitleniyor...");
        }
    }
}
