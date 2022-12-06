using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._1_console_
{
    internal class Program
    {
        static double recursion (double x, int n) //x в степени n - рекурсия
        {
            if (n == 0)
                return 1;
            else if (n < 0)
            {
               // return 1 / Math.Pow(x, Math.Abs(n));
               return 1 / recursion (x, Math.Abs (n));
            }
            return x * recursion(x, n - 1);
        }
        static void Main(string[] args)
        {
            
            int n;
            double x;

            do
            {
                Console.WriteLine("Введите x (вещественное число, больше 0)");
                if (!double.TryParse(Console.ReadLine(), out x) || x == 0)
                {
                    Console.WriteLine("Ошибка! X не является вещественным числом или равен нулю! Повторите попытку!");
                }
                else break;
            } while (true);

            do
            {
                Console.WriteLine("Введите n (целое число)");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Ошибка! N не является целым числом! Повторите попытку!");
                }
                else break;
            } while (true);

            Console.WriteLine(recursion(x, n));

        }
    }
}
