using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "ali", soyadi = "duman";
            int yas = 25, boy = 176, kilo = 78;
            Console.Write("adı soyadı: {0} {1} boyu: {2} kilosu: {3} yaşı: {4}", adi, soyadi, boy, kilo, yas);
            Console.ReadKey();
        }
    }
}
