using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarysearch_örneği
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ogrencino;
            ogrencino = new string[6] { "157", "174", "737", "145", "123", "174" };
            Array.Sort(ogrencino);
            foreach (string i in ogrencino)
                Console.Write(i + " ");
            Console.WriteLine("\nAranacak Öğrenci no:");
            string ogrno = Console.ReadLine();
            int eleman_index = Array.BinarySearch(ogrencino, ogrno);
            Console.WriteLine("Eleman index numarası:" + eleman_index);
            if (eleman_index <= -1)
                Console.Write("{0} numaralı öğrenci kaydı bulunamamıştır.", ogrno);
            else
                Console.Write("Öğrenci {0} . sırada kayıtlıdır.", eleman_index + 1);
            Console.ReadKey();
        }
    }
}
