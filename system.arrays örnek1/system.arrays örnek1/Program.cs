using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system.arrays_örnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] dizi1=new string[2];
            string[,] dizi2=new string[2,5];
            int boyut1=dizi1.Rank;
            int boyut2=dizi2.Rank;
            int eleman1=dizi1.Length;
            int eleman2=dizi2.Length;
            Console.WriteLine("dizi1 boyut:{0} dizi2 boyut:{1}", boyut1, boyut2);
            Console.Write("dizi1 eleman sayısı:{0} dizi2 eleman sayısı:{1}", eleman1, eleman2);
            Console.ReadKey();
        }
    }
}
