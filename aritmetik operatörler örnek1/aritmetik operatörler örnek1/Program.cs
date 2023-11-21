using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aritmetik_operatörler_örnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            int c = 8;
            double d = 5.5;
            a++;
            b = a + c;
            c = b % a;
            d--;
            Console.Write("a:{0} b:{1} c:{2} d:{3}", a, b, c, d);
            Console.ReadKey();
        }
    }
}
