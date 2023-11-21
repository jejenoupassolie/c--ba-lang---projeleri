using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toString_ile_tür_dönüşümü_örnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 8;
            string a1 = a.ToString();
            string b1 = b.ToString();
            Console.WriteLine(a + b);
            Console.WriteLine(a1 + b1);
            Console.ReadKey();

        }
    }
}
