using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysort_örneği
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = new string[5] { "istanbul", "bursa", "ankara", "izmir", "izmit" };
            Array.Sort(sehirler);
            for (int i = 0; i <=4; i++)
            {
                Console.WriteLine(sehirler[i]);
            }
            Console.ReadKey();
        }
    }
}
