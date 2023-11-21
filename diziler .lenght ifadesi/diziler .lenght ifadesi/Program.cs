using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler.lenght_ifadesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] sayilar = new double[5] { 25, 45, 50, 5, 20 };
            Console.WriteLine("eleman sayısı:" + sayilar.Length);
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.ReadKey();
        }


    }
}
