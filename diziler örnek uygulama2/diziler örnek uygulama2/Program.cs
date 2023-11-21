using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler_örnek_uygulama2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] sayilar= new double[5] {25,35,7,8,43};
            for (int i = 0; i<=4; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.ReadKey();
        }
    }
}
