using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_dögüsü_egzersiz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            Console.Write("1. sayıyı giriniz:");
            sayi1=Convert.ToInt16(Console.ReadLine());
            Console.Write("2. sayıyı giriniz:");
            sayi2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("sayılar:");
            if (sayi1 < sayi2)
            {
                for (int i = sayi1; i <= sayi2; i++)
                {
                    Console.WriteLine(i);
                }
            }
            if (sayi1 > sayi2)
            {
                for (int j = sayi1; j >= sayi2; j--)
                {
                    Console.WriteLine(j);
                }


            }
            else
            {
                Console.WriteLine("sayı aralığı oluşturulamadı, sayılar birbirine eşittir.");
            }
            Console.ReadKey();


        }
    }
}
