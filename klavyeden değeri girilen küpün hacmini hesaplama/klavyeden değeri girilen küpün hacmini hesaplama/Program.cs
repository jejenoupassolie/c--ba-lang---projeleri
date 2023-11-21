using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klavyeden_değeri_girilen_küpün_hacmini_hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kenar_uzunluğu = 0, hacim = 0;
            Console.Write("Küpün kenar uzunluğunu giriniz:");
            kenar_uzunluğu = Convert.ToInt16(Console.ReadLine());
            hacim = kenar_uzunluğu * kenar_uzunluğu * kenar_uzunluğu; // Math.Pow(kenar_uzunluğu,3); fonksiyonu da kullanılabilirdi.
            Console.Write("küpün hacmi:" + hacim); 
            Console.ReadKey();
            
        }
    }
}
