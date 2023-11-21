using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tek_boyutlu_dizi_örneği_günler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] günler = new string[7] { "pazartesi", "salı", "çarşamba", "perşembe", "cuma", "cumartesi", "pazar" };
            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine("haftanın {0}. günü {1}", i + 1, günler[i]);
            }
            Console.ReadKey();
        }
    }
}
