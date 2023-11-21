using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_döngüsü_egzersiz3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0 , toplam = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("{0}. Sayı:", i);
                sayi = Convert.ToInt16(Console.ReadLine());
                toplam = toplam + sayi;
            }
            Console.Write("Toplam:" + toplam);
            Console.ReadKey();
        }
    }
}
