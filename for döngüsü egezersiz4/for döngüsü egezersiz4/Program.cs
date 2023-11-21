using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace for_döngüsü_egezersiz4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("1.sayı:");
            sayi=Convert.ToInt16(Console.ReadLine());
            int enbuyuk = sayi;
            int enkucuk = sayi;
            for (int i = 1; i < 6; i++)
            {
                Console.Write("{0}.sayı:", i+1);
                sayi=Convert.ToInt16(Console.ReadLine());

                if (sayi>enbuyuk)
                    enbuyuk = sayi;

                if (sayi<enkucuk)
                    enkucuk = sayi;
            }
            Console.WriteLine("Girilen En Küçük Sayı={0}", enkucuk);
            Console.WriteLine("Girilen En Büyük Sayı={0}", enbuyuk);
            Console.ReadKey();
        }
    }
}
