using cuka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace pressFF
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 100; x++)
            {
                Console.WriteLine($"Пожождите идет загрузка");
                Console.Write($"{x}%");
                Thread.Sleep(30);
                Console.Clear();

            }

            sss func = new sss();
            func.bb();
            Console.WriteLine("1 - умножение");
            Console.WriteLine("2 - деление");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(" ");

            if (s <= 1)

            {
                Console.WriteLine($"Результат умножение: {func.Multiplication()}");
                Console.ReadLine();
            }

            else if (s >= 2)
            {
                Console.WriteLine($"Результат деление: {func.Division()}");
                Console.ReadLine();
            }

        }
    }
}

