using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
             * a = 5; b = 7 -> max = 7
             * a = 2 b = 10 -> max = 10
             * a = -9 b = -3 -> max = -3
             */
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a >= b) 
            {
                Console.WriteLine("Число " + a + " больше числа " + b);
            } else 
            {
                Console.WriteLine("Число " + b + " больше числа " + a);
            };
            Console.WriteLine("\n====================================\n");
             /* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
             * 
             * 2, 3, 7 -> 7
             * 44 5 78 -> 78
             * 22 3 9 -> 22
             */
            Console.Write("Введите первое число: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int c1 = Convert.ToInt32(Console.ReadLine());
            int max = a1;
            if (b1 > max)
            {
                max = b1;
            }
            if (c1 > max)
            {
                max = c1;
            }
            Console.WriteLine("Максимальное из введенных чисел: " + max);
            Console.WriteLine("\n====================================\n");
             /* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
             * 
             * 4 -> да
             * -3 -> нет
             * 7 -> нет
             */
            Console.Write("Введите число: ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            if (a2 % 2 == 0)
            {
                Console.WriteLine("Число " + a2 + " - четное");
            }
            else
            {
                Console.WriteLine("Число " + a2 + " - не четное");
            }
            Console.WriteLine("\n====================================\n");
             /* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
             * 
             * 5 -> 2, 4
             * 8 -> 2, 4, 6, 8
             */
            Console.Write("Введите число: ");
            int a3 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < a3; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(" " + i);
                    if (i == (a3 - 1))
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write(",");
                    }
                }
            }
            Console.ReadKey();
            
        }
    }
}
