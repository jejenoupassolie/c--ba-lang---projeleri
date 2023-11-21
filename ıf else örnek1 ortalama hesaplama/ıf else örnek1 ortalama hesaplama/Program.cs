using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ıf_else_örnek1_ortalama_hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yazili1, yazili2, ortalama;
            Console.Write("1.yazılı notunu giriniz:");
            yazili1=Convert.ToInt16(Console.ReadLine());
            Console.Write("2.yazılı notunu giriniz:");
            yazili2= Convert.ToInt16(Console.ReadLine());
            ortalama = (yazili1 + yazili2) / 2;
            if(ortalama>=50)
            {
                Console.Write("{0} ortalama ile geçti.", ortalama);

            }
            else
            {
                Console.Write("{0} ortalama ile kaldı", ortalama);

            }
            Console.ReadKey();
        }
    }
}
