using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_örnek_uygulama1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0, toplam = 0;
            char secim;
            do
            {
                Console.WriteLine("Lütfen Bir Reel Sayı Giriniz:");
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + sayi;
                Console.Write("Yeni Sayı Girilecek Mi?");
                secim = Convert.ToChar(Console.ReadLine());
            } while (secim == 'E' || secim == 'e');
            Console.Write("Sayıların Toplamı=" + toplam);
            Console.ReadKey();

        }
    }
}
