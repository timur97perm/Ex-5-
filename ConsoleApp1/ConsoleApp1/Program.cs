using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0;
            double x=0;
            bool succ = false;

            do
            {   Console.WriteLine("Введите целое число n");
                succ = int.TryParse(Console.ReadLine(), out n);
                if (!succ) Console.WriteLine("Введите целое число");
            } while (!succ);

            do
            {
                Console.WriteLine("Введите число x");
                succ = double.TryParse(Console.ReadLine(), out x);
                if (!succ) Console.WriteLine("Введите число");
            } while (!succ);

            double[,] mas = new double[n, 2 * n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < (n*2); j++)
                {
                    mas[i, j] = random.Next(100);
                    Console.Write(mas[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            bool b = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < (n * 2); j++)
                {
                    if (mas[i, j] > x)
                        b = false;
                }
                if (b == true)
                    Console.Write(1 + ", ");
                else Console.Write(0 + ", ");
                b = true;
            }
            Console.ReadLine();
        }
    }
}
