using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace düzensiz_diziler_örnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] dizi=new int[3][];
            dizi[0]= new int[] {1,2,3};
            dizi[1]= new int[] {1,2,3,4};
            dizi[2]= new int[] {1,2,3,4,5};
            for(int i = 0; i < dizi.Length; i++)
            {
                for(int j = 0; j < dizi[i].Length; j++)
                    Console.WriteLine("{0}.satır {1}. sütun:{2}", i + 1, j + 1, dizi[i][j]);
            }
            Console.ReadKey();
        }


    }
}
