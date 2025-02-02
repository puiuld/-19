using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19._2
{
    internal class Program
    {
        /// <summary>
        /// Вывести первые пять членов арифметической прогрессии (с использованием цикла) 
        /// и найти их общую сумму, если a1=1, d=4 (например, 1  5  9  13  17, sum=45).
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int a1 = 1;
            int d = 4;
            int n = 5;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = a1 + i * d;
                Console.Write(num + " ");
                sum += num;
            }

            Console.WriteLine($"Сумма:{sum}");
            Console.ReadLine();
        }
    }
}