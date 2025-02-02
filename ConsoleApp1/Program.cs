using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19._3
{
    internal class Program
    {
        /// <summary>
        /// Родители ко дню рождения своего сына Андрея решили купить и обновить ему мобильный телефон. 
        /// Для этого они в первый месяц отложили 100 руб., 
        /// а в каждый последующий на 50 рублей больше. 
        /// Какая сумма будет через десять месяцев?
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int a = 100; 
            int d = 50;   
            int n = 10;   
            int sum = 0;  

            for (int i = 0; i < n; i++)
            {
                int num = a + i * d; 
                sum += num; 
            }

            Console.WriteLine($"Сумма через 9 месяцев: {sum}" );
            Console.ReadLine();

        }
    }
}