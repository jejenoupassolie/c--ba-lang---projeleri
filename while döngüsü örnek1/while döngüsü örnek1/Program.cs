﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_döngüsü_örnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i<10)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadKey();
        }
    }
}
