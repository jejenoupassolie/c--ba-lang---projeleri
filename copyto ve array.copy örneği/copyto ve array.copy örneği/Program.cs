using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copyto_ve_array.copy_örneği
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi1 = new int[7] { 4, 5, 6, 7, 8, 9, 10 };
            int[] dizi2 = new int[10];
            int[] dizi3 = new int[5];
            Console.WriteLine("Dizi1 elemanları:");
            foreach (int i in dizi1)
            {
                Console.Write(i+" ");

            }
            dizi1.CopyTo(dizi2, 3); // copy to dizi1 in dizi2 after the 3rd element. 
            Console.WriteLine("\n\nDizi2 elemanları:");
            foreach (int i in dizi2)

            {
                Console.Write(i + " ");
            }
            Array.Copy(dizi1, 2, dizi3, 1, 4);
            Console.WriteLine("\n\nDizi3 elemanları:");
            foreach (int i in dizi3)

            {
                Console.Write(i + " ");
            }
            Console.ReadKey();


        }
    }
}
