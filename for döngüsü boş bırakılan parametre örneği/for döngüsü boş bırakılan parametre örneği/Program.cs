using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_döngüsü_boş_bırakılan_parametre_örneği
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            for(; sayi<=15 ; )
            {
                Console.WriteLine(sayi);
                sayi = sayi + 3;
            }
            Console.ReadKey();        }
    }
}
