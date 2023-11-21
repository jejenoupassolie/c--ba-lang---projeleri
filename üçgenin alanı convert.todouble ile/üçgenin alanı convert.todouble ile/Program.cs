using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace üçgenin_alanı_convert.todouble_ile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double taban_uzunluk = 0, yükseklik = 0, alan = 0;
            Console.Write("Taban uzunluğunu giriniz:");
            taban_uzunluk = Convert.ToDouble(Console.ReadLine());
            Console.Write("Yüksekliği giriniz:");
            yükseklik = Convert.ToDouble(Console.ReadLine());
            alan = (taban_uzunluk * yükseklik) / 2;
            Console.Write("Üçgenin alanı:" + alan);
            Console.ReadKey();

        }
    }
}
