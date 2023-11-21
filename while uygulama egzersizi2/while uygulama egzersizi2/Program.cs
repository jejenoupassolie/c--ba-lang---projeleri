using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_uygulama_egzersizi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi_adeti=0, sayac=1, limit=0;
            Console.Write("Aralık üst sınırı [1-?]:");
            limit=Convert.ToInt16(Console.ReadLine());
            while(sayac<=limit)
            {
                if (sayac%3==0 && sayac%7==0)
                {
                    Console.WriteLine(sayac);
                    sayi_adeti++;
                }
                sayac++;
                
            }
            if (sayi_adeti > 0)
                Console.Write("hesaplanan sayı adedi:" + sayi_adeti);
            else
                Console.Write("3 ve 7 nin katı olan sayı yoktur.");
            Console.ReadKey();
        }

    }
}
