using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._2_console_
{
    internal class Program
    {
        static void recursion(int n, int row)
        {
            if (row > n)
                return;

            for (int i = row; i > 0; i--)
            {
                Console.Write("  " + i);
            }
            Console.WriteLine(" ");
            recursion(n, row + 1);
        }
            static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Введите n = ");
                if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    Console.WriteLine("Ошибка! N не является целым числом или имеет отрицательное или нулевое значение");
                }
                else break;
            } while (true);

            recursion(n, 1);
        }
    }
}

