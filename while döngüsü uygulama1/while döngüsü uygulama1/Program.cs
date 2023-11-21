using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_döngüsü_uygulama1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0, toplam = 0, sayac=1;
            while(sayac<=5)

            {
                Console.Write("{0}. sayı:", sayac);
                sayi = Convert.ToInt16(Console.ReadLine());
                toplam = toplam + sayi;
                sayac++;

            }
            
            Console.Write("sayıların toplamı:" + toplam);
            Console.ReadKey();


        }
    }
}
