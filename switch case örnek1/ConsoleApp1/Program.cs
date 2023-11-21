using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int plaka_kodu;
            Console.Write("İl plaka kodunu giriniz:");
            plaka_kodu=Convert.ToInt16(Console.ReadLine());
            switch(plaka_kodu)
            {
                case 37:
                    Console.Write("37:Kastamonu");
                    break;

                case 42:
                    Console.Write("42:Konya");
                    break;

                case 16:
                    Console.Write("16:Bursa");
                    break;

                case 06:
                    Console.Write("06:Ankara");
                    break;

                case 34:
                    Console.Write("34:İstanbul");
                    break;

                default:
                    Console.Write("İl plaka kodu:{0} \n{0} plaka kodu geçersizdir.", plaka_kodu);
                    break;


            }
            Console.ReadKey();
        }
    }
}
