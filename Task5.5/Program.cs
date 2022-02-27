using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива (>=2)");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите массив");
            int[,] array = new int[n,n];
            bool f = true;
            int s = 0;
            int sstr = 0;
            int sstlb = 0;
            int sdiag1 = 0;
            int sdiag2 = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i,j]=Convert.ToInt32(Console.ReadLine());
                }                
                s += array[i, 1];
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sstr += array[i, j];
                }
                if (sstr != s)
                {
                    f = false;
                }
                sdiag1 += array[i, i];
                sdiag2 += array[i, n - i - 1];
                sstr = 0;                
            }
            for (int j = 0; j < n; j++)
            {
                for (int i = n-1; i > -1; i+=-1)
                {
                    sstlb += array[i, j];
                }
                if (sstlb != s)
                {
                    f = false;
                }
                sstlb = 0;
            }          
            if ((sdiag1!=s)||(sdiag2!=s))
            {
                f = false;
            }
            if (!f)
            {
                Console.WriteLine("Введенный массив не является магическим квадратом");
            }
            else
            {
                Console.WriteLine("Введенный массив является магическим квадратом");
            }
            Console.ReadKey();
        }
    }
}
