using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace silindirin_hacmini_hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double yaricap = 0, yükseklik = 0, hacim = 0;
            const double pi = 3.14;
            Console.Write("Silindirin yarıçapını giriniz:");
            yaricap = Convert.ToDouble(Console.ReadLine());
            Console.Write("Silindirin yüksekliğini giriniz:");
            yükseklik = Convert.ToDouble(Console.ReadLine());
            hacim = pi * yaricap * yaricap * yükseklik; //yarıçapın karesi için Math.Pow(yaricap,2) kullanabilirdik.
            Console.Write("Silindirin hacmi:" + hacim);
            Console.ReadKey();





        }
    }
}
