using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayındexof_örneği
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] plakalar = new string[5] { "37", "47", "06", "42", "34" };
            Console.WriteLine("plaka sırası:{0}", Array.IndexOf(plakalar, "42"));
            Console.ReadKey();

        }
    }
}
