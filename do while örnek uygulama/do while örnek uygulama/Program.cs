using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_örnek_uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string k_adı = "İstanbul", k_sifre = "1453";
            string kullanici_adi, sifre;
            int kalan_hak=3;


            do
            {
                Console.WriteLine("Kullanıcı Girişi Kalan Hak:" + kalan_hak);
                Console.Write("Kullanıcı adı:");
                kullanici_adi = Console.ReadLine();
                Console.Write("Şifre:");
                sifre = Console.ReadLine();
                kalan_hak--;
                if (kullanici_adi == k_adı && sifre == k_sifre)

                    Console.Write("Hoş geldiniz.");

                if ((kullanici_adi != k_adı || sifre != k_sifre) && kalan_hak == 0)
                    Console.WriteLine("Kullanıcı girişi hakkınız kalmadı.");
            }
            while ((kullanici_adi != k_adı || sifre != k_sifre) && kalan_hak != 0);

        }
    }
}
