using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktoriyel_hesaplama_while_ile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0, faktöriyel=1;
            Console.Write("Faktöriyeli bulanacak sayı:", sayi);
            sayi=Convert.ToInt16(Console.ReadLine());
            
            while(sayi>0)
            {
                faktöriyel *= sayi;
                sayi--;
            
            }
            Console.Write("sonuç:" + faktöriyel);
            Console.ReadKey();

        }
    }
}
