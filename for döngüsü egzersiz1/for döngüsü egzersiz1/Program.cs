using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_döngüsü_egzersiz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i <= 400; i++)
            {
                if(i%9== 0 && i % 7 == 0)
                {

                    Console.WriteLine(i);

                }
            }
            Console.ReadKey();
        }
    }
}
