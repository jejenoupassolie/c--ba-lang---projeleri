using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ıf_else_ikizkenar_örnek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kenar1, kenar2, kenar3;
            Console.Write("1. kenar uzunluğunu giriniz:");
            kenar1=Convert.ToInt16(Console.ReadLine());
            Console.Write("2. kenar uzunluğunu giriniz:");
            kenar2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("3. kenar uzunluğunu giriniz:");
            kenar3 = Convert.ToInt16(Console.ReadLine());
            if(kenar1 == kenar2 || kenar1 == kenar3 || kenar2 == kenar3)
            {
                Console.Write("Üçgen İkizkenardır.");
            }
            else
            {
                Console.Write("Üçgen ikizkenar değilsir.");

            }
            Console.ReadKey();
        }
    }
}
