using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ıf_else_kontrol_yapısı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (true) //if 'ıf(false)', 'else' codes, run.
            {
                Console.Write("true değeri döndürüldü."); 
            }
            else
            {
                Console.Write("false değeri döndürüldü");

            }
            Console.ReadKey();
        }
    }
}
