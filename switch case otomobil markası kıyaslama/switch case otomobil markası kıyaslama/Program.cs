using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace switch_case_otomobil_markası_kıyaslama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string otomobil_markasi;
            Console.Write("Otomobil markası:");
            otomobil_markasi = Console.ReadLine();
            switch(otomobil_markasi.ToUpper()) // system will accept of process with .toupper() when user enter of data small or big character. 
            {
                case "opel":
                    Console.Write("Opel: Astra, Vectra, Mokka");
                    break;

                case "renault":
                    Console.Write("Renault: Clio, Megane, Talisman");
                    break;

                case "honda":
                    Console.Write("Honda: Civic, Accord, City");
                    break;

                default:
                    Console.Write("Otomobil markası kayıtlı değildir.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
