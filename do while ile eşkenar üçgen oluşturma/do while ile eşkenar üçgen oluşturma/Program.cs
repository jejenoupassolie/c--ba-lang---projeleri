using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_ile_eşkenar_üçgen_oluşturma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kenar1=0,kenar2=0,kenar3=0;

            do
            {
                Console.WriteLine("Üçgen Kenar uzunlukları");
                Console.Write("1.kenar:");
                kenar1=Convert.ToInt32(Console.ReadLine());
                Console.Write("2.kenar:");
                kenar2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("3.kenar:");
                kenar3 = Convert.ToInt32(Console.ReadLine());


            } while (kenar1!=kenar2 || kenar2!=kenar3 || kenar1!=kenar3);
            Console.Write("Eşkenar üçgen oluştu.");
            Console.ReadKey();
        }
    }
}
