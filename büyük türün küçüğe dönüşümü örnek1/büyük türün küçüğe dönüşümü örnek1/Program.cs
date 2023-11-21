using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace büyük_türün_küçüğe_dönüşümü_örnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 256;
            byte b = (byte)a;
            Console.Write("a:{0} b:{1}", a, b); // at screen output will you see b variable value as  0, because int variable can keep to number until to max 255.
            Console.ReadKey();
        }
    }
}
