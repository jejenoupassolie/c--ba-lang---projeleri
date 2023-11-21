using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atama_operatörleri_örnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 9, b = 7, c = 5;
            a += 3; //a=a+3;
            b -= c; //b=b-c;
            a %= c; //a=a%c;
            Console.Write("a:{0} b:{1} c:{2}", a, b, c);
            Console.ReadKey();

        }
    }
}
