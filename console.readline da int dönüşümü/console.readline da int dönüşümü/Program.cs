using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console.readline_da_int_dönüşümü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yazili1 = 0, yazili2 = 0, ortalama = 0;
            Console.Write("1. yazılı notunu giriniz:");
            yazili1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2. yazılı notunu giriniz:");
            yazili2 = Convert.ToInt16(Console.ReadLine());
            ortalama = (yazili1 + yazili2) / 2;
            Console.Write("1. yazılı notu: {0} 2.yazılı notu: {1} yazılı notu ortalaması: {2}", yazili1, yazili2, ortalama);
            Console.ReadKey();
        }
    }
}
