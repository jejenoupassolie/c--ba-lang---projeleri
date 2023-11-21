using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace çoklu_diziler_örnek_uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] tablo = new string[4, 5];
            double ortalama;
            for (int i = 0; i <=3; i++) 
            {
                Console.WriteLine("*** {0} . ÖĞRENCİ BİLGİLERİ ***", i+1);
                Console.Write("Öğrenci no:");
                tablo[i,0] = Console.ReadLine();
                Console.Write("Öğrenci Adı-soyadı:");
                tablo[i, 1] = Console.ReadLine();
                Console.Write("Vize notu:");
                tablo[i, 2] = Console.ReadLine();
                Console.Write("Final notu:");
                tablo[i, 3] = Console.ReadLine();
                ortalama = double.Parse(tablo[i, 2]) * 0.4 + double.Parse(tablo[i, 3]) * 0.6;
                ortalama=Math.Round(ortalama,2);
                tablo[i,4] =Convert.ToString(ortalama);


            }
            for (int i = 0;i <=3;i++) 
            {
                Console.WriteLine("Öğrenci no:{0} Adı-soyadı:{1} Vize notu:{2} Final notu:{3} ortalama:{4}", tablo[i,0], tablo[i, 1], tablo[i, 2], tablo[i, 3], tablo[i, 4]);
            }
            Console.ReadKey();

        }
    }
}
