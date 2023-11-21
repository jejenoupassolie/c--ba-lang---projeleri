using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace içiçe_if_else_örnek1_ücgenin_çeşidi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kenar1, kenar2, kenar3;
            Console.Write("1.kenar uzunluğu:");
            kenar1=Convert.ToDouble(Console.ReadLine());
            Console.Write("2.kenar uzunluğu:");
            kenar2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("3.kenar uzunluğu:");
            kenar3 = Convert.ToDouble(Console.ReadLine());
            if (kenar1 == kenar2 && kenar1 == kenar3 && kenar2 == kenar3)
            {
                Console.Write("üçgen eşkenardır.");
            }
            else
            {
                if (kenar1 == kenar2 || kenar1 == kenar3 || kenar2 == kenar3)
                {
                    Console.Write("üçgen ikizkenardır.");
                }
                else
                {
                    Console.Write("üçgen çeşitkenardır.");
                }
            }
                Console.ReadKey();
        }
    }
}
