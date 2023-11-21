using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_örnek_uygulama_sınav_nıotu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vize = 0, final = 0, ortalama = 0;
            Console.Write("vize notunu giriniz:");
            vize = Convert.ToInt16(Console.ReadLine());
            Console.Write("final notunu giriniz:");
            final = Convert.ToInt16(Console.ReadLine());
            ortalama = ((0.4 * vize) + (0.6 * final));
            if (ortalama == 0 && ortalama <= 29)
                Console.Write("{0} FF ile kaldınız", ortalama);
            else if (ortalama >= 30 && ortalama <= 49)
                Console.Write("{0} FD ile kaldınız.", ortalama);
            else if (ortalama >= 50 && ortalama <= 54)
                Console.Write("{0} DC ile şartlı geçtiniz.", ortalama);
            else if (ortalama >= 55 && ortalama <= 59)
                Console.Write("{0} DD ile şartlı geçtiniz.", ortalama);
            else if (ortalama >= 60 && ortalama <= 64)
                Console.Write("{0} CC ile geçtiniz.", ortalama);
            else if (ortalama >= 65 && ortalama <= 69)
                Console.Write("{0} CB ile geçtiniz.", ortalama);
            else if (ortalama >= 70 && ortalama <= 79)
                Console.Write("{0} BB ile geçtiniz.", ortalama);
            else if (ortalama >= 80 && ortalama <= 89)
                Console.Write("{0} BA ile geçtiniz.", ortalama);
            else if(ortalama>=90 && ortalama<=100)
                Console.Write("{0} AA ile geçtiniz", ortalama);
            Console.ReadKey();
        }
    }
}
