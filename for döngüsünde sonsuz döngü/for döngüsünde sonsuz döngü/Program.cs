using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_döngüsünde_sonsuz_döngü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 1;
                for (; ; )
            {
                Console.WriteLine(sayi);
                sayi++;
            }
            Console.ReadKey();
        }
    }
}
