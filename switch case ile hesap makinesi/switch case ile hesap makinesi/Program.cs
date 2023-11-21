using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case_ile_hesap_makinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, toplama, cıkarma, carpma, bölme, secim;
            Console.Write("sayı 1:");
            sayi1=Convert.ToInt16(Console.ReadLine());
            Console.Write("sayı 2:");
            sayi2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("1-Toplama \n2-Çıkarma \n3-Çarpma \n4-Bölme\n");
            Console.WriteLine("lütfen bir seçim yapınız:");
            secim=Convert.ToInt16(Console.ReadLine());
            toplama = sayi1 + sayi2;
            cıkarma = sayi1 - sayi2;
            carpma = sayi1 * sayi2;
            bölme = sayi1 / sayi2;

            switch (secim)
            {

                case 1:
                    Console.Write("seçiminiz(1,2,3,4):1 \n Toplama sonucu: {0}", toplama);
                        break;

                    case 2:
                    Console.Write("seçiminiz(1,2,3,4):2 \n Çıkarma sonucu: {0}", cıkarma);
                    break;

                    case 3:
                    Console.Write("seçiminiz(1,2,3,4):3 \n Çarpma sonucu: {0}", carpma);
                    break;

                    case 4:
                    Console.Write("seçiminiz(1,2,3,4):4 \n Bölme sonucu: {0}", bölme);
                    break;

                default:
                    Console.Write("HATALI MENÜ GİRİŞ YAPILDI.");
                        break;





            }
            Console.ReadKey();

        }
    }
}
