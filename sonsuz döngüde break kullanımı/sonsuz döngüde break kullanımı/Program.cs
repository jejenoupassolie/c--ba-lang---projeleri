using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sonsuz_döngüde_break_kullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0, toplam = 0;
            char secim;
            for (; ; )
            {
                Console.Write("Toplama İşlemini iptal etmek için H veya h karakteri giriniz:");
                secim = Convert.ToChar(Console.ReadLine());
                if (secim =='H' || secim == 'h')
                {
                    break;
                }
                Console.Write("sayı:");
                sayi = Convert.ToInt16(Console.ReadLine());
                toplam = toplam + sayi;
            }
            Console.Write("Sayıların toplamı:" + toplam);
            Console.ReadKey();
            }
        }
    }
