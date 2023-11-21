using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_kullanıcı_girişi_örneği
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kullanici_adi, parola;
            Console.Write("kullanıcı adını giriniz:");
            kullanici_adi=Console.ReadLine();
            Console.Write("parolayı giriniz:");
            parola=Console.ReadLine();
            if (kullanici_adi=="İstanbul" && parola=="1453")
            {
                Console.Write("giriş başarılı");
            }
            else
            {
                if(kullanici_adi!="İstanbul" && parola=="1453")
                    Console.Write("kullanıcı adı hatalı,giriş başarısız.");
                if(kullanici_adi=="İstanbul" && parola!="1453")
                    Console.Write("parola hatalı, giriş başarısız.");
                if (kullanici_adi != "İstanbul" && parola != "1453")
                    Console.Write("parola hatalı ve kullanıcı adı hatalı,lütfen tekrar deneyiniz.");
            }
            Console.ReadKey();

            
        }
    }
}
