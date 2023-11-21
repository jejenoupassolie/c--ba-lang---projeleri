using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_döngüsü_örnek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 50; i > 0 ; i=i-5)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
