using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n =10;
            int[] array = new int[n];
            Random random = new Random();            
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.WriteLine("{0}", array[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (array[i] > array[j])
                    {
                        int T = array[i];
                        array[i] = array[j];
                        array[j] = T;
                    }
                }
            }
            for (int i = 5; i < 9; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (array[i] < array[j])
                    {
                        int T = array[i];
                        array[i] = array[j];
                        array[j] = T;
                    }
                }
            }
            foreach (int a in array)
            {
                Console.WriteLine("{0}", a);
            }
            Console.ReadKey();
        }
    }
}
