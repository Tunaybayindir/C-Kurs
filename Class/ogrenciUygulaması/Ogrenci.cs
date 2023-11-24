using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciUygulaması1
{
    public class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrNo;
        private int vize1;
        private int vize2;
        private int final;
        private string okulIsmi;
        public Ogrenci(string _isim, string _soyisim, int _ogrNo, int _vize1, int _vize2, int _final, string _okulIsmi)
        {
            isim = _isim;
            soyisim = _soyisim;
            ogrNo = _ogrNo;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            okulIsmi = _okulIsmi;
        }
        public void ogrenciBilgileriGoster()
        {
            Console.WriteLine("isim: " + isim);
            Console.WriteLine("soyisim: " + soyisim);
            Console.WriteLine("ogrenci no: " + ogrNo);
            Console.WriteLine("Vize1: " + vize1);
            Console.WriteLine("Vize2: " + vize2);
            Console.WriteLine("Final: " + final);
            Console.WriteLine("Okul ismi: " + okulIsmi);

        }
        public double ogrenciOrtalama()
        {
            double ortalama = vize1 * 0.2 + vize2 * 0.2 + final * 0.6;
            return ortalama;
        }
        public void ogrenciOkulGoster()
        {
            Console.WriteLine("Okul İsmi: " + okulIsmi);
        }
    }
}
