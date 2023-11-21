
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_döngüsü_iminde_veri_girişi_örneği
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("sayaç değeri:");
            for (int i = Convert.ToInt16(Console.ReadLine()); i < 45; i=i+5)
            {
                Console.WriteLine(i);

            }
            Console.ReadKey();
        }
    }
}
