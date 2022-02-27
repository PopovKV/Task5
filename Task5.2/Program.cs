using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 15;
            int[] array = new int[n];
            Random random = new Random();
            int max = 0;
            int min = 50;            
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0,50);
                Console.WriteLine("{0}", array[i]);
            }
            Console.WriteLine();
            foreach (int a in array)
            {
                if (a<=min)
                {
                    min = a;
                }
                if (a>=max)
                {
                    max = a;
                }              
            }
            max += min;
            Console.WriteLine("Сумма минимального и максимального элемента = {0}", max);
            Console.ReadKey();
        }
    }
}
