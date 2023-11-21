using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilinçsiz_tür_dönüşümü_örnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 5;
            int b = a;

            float c = 20f;
            double d = c;

            Console.Write("a:{0} b:{1} c:{2} d:{3}", a, b, c, d);
            Console.ReadKey();


        }
    }
}
