using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayreverse_örneği
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = new string[5] { "istanbul", "bursa", "izmir", "ankara", "tokat" };
            Array.Reverse(sehirler);
            foreach (string s in sehirler)
            {
                Console.WriteLine(s);

            }
            Console.ReadKey();
        }
    }
}
