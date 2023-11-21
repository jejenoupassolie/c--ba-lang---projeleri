using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mantıksal_operaötler_değil_not__örnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 7, c = -3, d = 3;
            bool sonuc = !(a > 0 || c < 0 || d == 0);
            Console.Write(sonuc);
            Console.ReadKey();
        }
    }
}
