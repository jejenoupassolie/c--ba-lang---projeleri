using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_3_convert.toınt16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int uzunkenar = 0, kisakenar = 0, alan = 0, cevre = 0;
            Console.Write("dikdörtgenin uzun kenarını giriniz:");
            uzunkenar = Convert.ToInt16(Console.ReadLine());
            Console.Write("dikdörtgenin kısa kenarını giriniz:");
            kisakenar = Convert.ToInt16(Console.ReadLine());
            alan = (kisakenar + uzunkenar)*2;
            cevre = kisakenar * uzunkenar;
            Console.Write("dikdörtgenin alanı:{0} dikdörtgenin çevresi:{1}", alan, cevre);
            Console.ReadKey();


        }
    }
}
