
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 5;
            int b = (int)a; // dönüştürülecek değişken ismini, hangi türe dönüştüreceksek tür dönüştürme operatörünü kullanmamız gerekir.
            Console.Write(b);
            Console.ReadKey();
        }
    }
}
