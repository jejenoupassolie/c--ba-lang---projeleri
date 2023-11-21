using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tckimlikno, adi, soyadi;
            Console.Write("TC KİMLİK NO:");
            tckimlikno = Console.ReadLine();
            Console.Write("ADI:");
            adi = Console.ReadLine();
            Console.Write("SOYADI:");
            soyadi = Console.ReadLine();
            Console.Write("TC KİMLİK NO: {0} ADI: {1} SOYADI: {2}", tckimlikno, adi, soyadi);
            Console.ReadKey();
        }
    }
}
