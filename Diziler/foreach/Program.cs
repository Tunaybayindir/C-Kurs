using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 1, 2, 3, 4, 5 };

            foreach (int item in sayilar)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
