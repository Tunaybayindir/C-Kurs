using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriTipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 Byte = 8 bit  
            //1 KB = 1024 Byte 
            //1 MB = 1024 KB

            //Byte-(0-255)
            //1byte 

            byte birinci = 1;
            byte ucuncu = 255;
            byte max_deger = Byte.MaxValue;
            byte min_deger = Byte.MinValue;

            Console.WriteLine(birinci);
            Console.WriteLine(ucuncu);
            Console.WriteLine(max_deger);
            Console.WriteLine(min_deger);

            //Short-(-32768 ile 32767)
            // 4 byte yer kaplar

            short short_max_deger = short.MaxValue;
            short short_min_deger = short.MinValue;

            Console.WriteLine(short_max_deger);
            Console.WriteLine(short_min_deger);

            // int 4 byte yer kaplar (-2.147.483.648 - 2.147.483.637)"
            // 8 byte yer kaplar

            int int_max_deger = int.MaxValue;
            int int_min_deger = int.MinValue;

            Console.WriteLine(int_max_deger);
            Console.WriteLine(int_min_deger);

            // Long 8 byte Kaplar (-9223372036854775807 +9223372036854775808)


            long long_max_deger = long.MaxValue;
            long long_min_deger = long.MinValue;

            Console.WriteLine(long_max_deger);
            Console.WriteLine(long_min_deger);

            // Float 4 byte yer kaplar (-3,402823E+38 +3,402823E+38) 7 basamaklı max
            float float_veri = 3.5f; //f koyulmazsa sonuna double olarak algılar
            float float_max_deger = float.MaxValue;
            float float_min_deger = float.MinValue;
            Console.WriteLine(float_veri);
            Console.WriteLine(float_max_deger);
            Console.WriteLine(float_min_deger);

            // Double 8 byte yer kaplar  15 basamaklı ondalıklı sayılarıda tutabilir
            double ondalikli = 350.7;
            double ondalikli_iki = -256.4;
            double double_max_deger = double.MaxValue;

            Console.WriteLine(ondalikli);
            Console.WriteLine(ondalikli_iki);
            Console.WriteLine(double_max_deger);

            // char tek bir karakteri tutmak için kullanılır
            // tek tırnakla tanımlanır

            char karakter = 't';
            Console.WriteLine(karakter);

            // string metinleri tutarız

            string ad = "tunay";
            string soyad = "bayındır";
            Console.WriteLine(ad);
            Console.WriteLine(soyad);

            //boolean 2 değerli

            bool kontrol = true;
            bool sonu = 10 > 5;

            Console.WriteLine(kontrol);
            Console.WriteLine(sonu);

            // object veri tipi tüm verileri tutabilir

            object s = 10;
            Console.WriteLine(s);
            Console.ReadLine();

        }
    }
}
