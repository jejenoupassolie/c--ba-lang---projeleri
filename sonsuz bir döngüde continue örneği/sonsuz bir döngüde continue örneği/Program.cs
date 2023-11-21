using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sonsuz_bir_döngüde_continue_örneği
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0, toplam = 0;
            for (; ; )
            {
                Console.Write("Pozitif Tam Sayı Giriniz:");
                sayi = Convert.ToInt16(Console.ReadLine());
                if (sayi == 0)
                {
                    break;
                }
                if (sayi < 0)
                {
                    Console.WriteLine("Lütfen Pozitif Tam Sayı Giriniz:");
                    continue;
                }
                else
                {
                    toplam = toplam + sayi;

                }
            }
            Console.Write("Sayıların Toplamı:" + toplam);
            Console.ReadKey();
        }
    }
}
