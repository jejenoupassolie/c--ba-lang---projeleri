using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace büyükten_küçüğe_tğr_dönüşümü_ondalıklı_örnek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 25.52f;
            int b = (int)a;
            Console.Write("a:{0} b:{1}", a, b); // when we decimal variable convert can be data lose. like this; while section of decimal convert to int variable has lose decimal part.
            Console.ReadKey();




        }
    }
}
