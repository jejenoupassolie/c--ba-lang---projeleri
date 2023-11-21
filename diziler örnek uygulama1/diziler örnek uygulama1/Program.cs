using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler_örnek_uygulama1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ortalama = 0,toplam=0;
            double[] sayilar = new double[5];
            sayilar[0] =14.50;
            sayilar[1] =02.50;
            sayilar[2] =06.09;
            sayilar[3] =12.50;
            sayilar[4] =11.50;
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("{0}. sayı:", i + 1);
                sayilar [i] = Convert.ToDouble(Console.ReadLine());
                toplam = toplam + sayilar[i];
              
            }
            ortalama =Math.Round(toplam/5,2); // we can use for avarage value the a math formule (math.Raund). like this; ortalama=math.raund(toplam/5,2);. math.raund means; round the mathematically. we can write from after comma, if we want to round how many digits;
            Console.Write("ortalaması:" + ortalama); 
            Console.ReadKey();
        }
    }
}
