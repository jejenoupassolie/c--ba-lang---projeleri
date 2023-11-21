using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ıf_else_yapısı_tekçift_örnek3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0, kalan=0;
            Console.Write("bir sayı giriniz:");
            sayi=Convert.ToInt16(Console.ReadLine());
            kalan = sayi %= 2;
            if(kalan==0)
            {
                Console.Write("sayı çifttir.");

            }
            else
            {
                Console.Write("sayı tektir.");

            }
            Console.ReadKey();
        }
    }
}
