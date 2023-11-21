using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_döngüsü_uygulama2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0, ortalama = 0, toplam=0,sayac=0;
            Console.Write("sayı:");
            sayi = Convert.ToInt16(Console.ReadLine());

            while (sayac>=0)
            {
                Console.Write("sayı:");
                sayi = Convert.ToInt16(Console.ReadLine());
                if (sayi == 0)
                    break;

                toplam = toplam + sayi;
                sayac++;
                
            }
            ortalama = toplam / sayac;
            Console.Write("sayıların ortalaması:" + ortalama);
            Console.ReadKey();
        }

    }
}
