using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ıf_else_iş_başvurusu_kabulu_örnek4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int boy = 0, kilo = 0;
            Console.Write("boyunuzu giriniz.");
            boy=Convert.ToInt16(Console.ReadLine());
            Console.Write("kilonuzu giriniz.");
            kilo = Convert.ToInt16(Console.ReadLine());
            if(boy>=165 && (kilo<=80 || kilo>=60))
            {
                Console.Write("iş başvurusu kabul edilmiştir.");

            }
            else
            {
                Console.Write("iş başvurusu reddedilmiştir");

            }
            Console.ReadKey();
        }
    }
}
