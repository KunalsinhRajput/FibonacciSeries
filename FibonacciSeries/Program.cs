﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
     class Program
    {
        public static void Main(String[] args)
        {
            int a = 0;
            int b = 1;
            int c;
            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 0; i <= 10; i++)
            {
                c= a + b;

                Console.WriteLine(c);
                a = b;
                b=c;

            }
            Console.ReadLine();
         



        }
    }
}
