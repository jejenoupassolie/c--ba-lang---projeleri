using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_if_basamak_yapısı_örnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("bir sayı giriniz:");
            sayi=Convert.ToInt16(Console.ReadLine());
            if(sayi==0)
            {
                Console.Write("{0} sayısı sıfıra eşittir.", sayi);
            }
            else if(sayi<0)
            {
                Console.Write("{0} sayısı negatiftir", sayi);
            }
            else

            {
                Console.Write("{0} sayısı pozitiftir.", sayi);
            }
            Console.ReadKey();
        }
    }
}
