using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constant_value_ile_tür_dönüşümü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int a = 255;
            const byte b = (byte)a;
            Console.Write("a:{0} b:{1}", a, b);
            Console.ReadKey();
        }
    }
}
