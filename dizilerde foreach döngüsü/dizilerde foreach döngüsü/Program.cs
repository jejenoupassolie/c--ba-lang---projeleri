using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizilerde_foreach_döngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] sayilar=new double[5] {25,35,7,8,43};
            foreach(double eleman in sayilar) 
            {
                Console.WriteLine(eleman);
            }
            Console.ReadKey();
        }
    }
}
