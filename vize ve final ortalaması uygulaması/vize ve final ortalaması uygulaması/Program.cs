using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vize_ve_final_ortalaması_uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vize = 0, final = 0, ortalama = 0;
            Console.Write("vize notunu giriniz:");
            vize = Convert.ToInt16(Console.ReadLine());
            Console.Write("final notunu giriniz:");
            final = Convert.ToInt16(Console.ReadLine());
            ortalama = ((vize * 40 / 100) + (final * 60 / 100)) / 2; // yüzdelik sayı yazmak için 0.4 ya da 0.6 kullanabilirdik.
            Console.Write("vize: {0}\nfinal: {1}\nnot ortalaması: {2}", vize, final, ortalama);
            Console.ReadKey();
        }
    }
}
