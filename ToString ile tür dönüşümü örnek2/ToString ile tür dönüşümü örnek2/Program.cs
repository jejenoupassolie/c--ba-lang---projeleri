using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToString_ile_tür_dönüşümü_örnek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a=5.2, b = 3.8; ;
            string a1 = a.ToString();
            string b2 = b.ToString();
            Console.WriteLine(a + b);
            Console.WriteLine(a1 + b2);
            Console.ReadKey();

        }
    }
}
