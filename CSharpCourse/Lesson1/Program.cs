using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {

        static void Main(string[] args)
        {
            /*Написать программу: пользователь вводит на консоль 3 числа.
 Нужно:
 - вывести наименьшее;
 - последовательности чисел Фибоначчи, последний элемент каждого из которых меньше соответствующего из трех чисел (3 последовательности).*/

            int F, a, c, b, min = 0;
            int d = 0, e = 1;

            Console.WriteLine("Введите первое число, больше 1"); // больше 1 - чтобы первые числа фибоначчи хотя бы прописывались - это 0 1 1
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число, больше 1");
            b = int.Parse(Console.ReadLine());
            if (a < b)
            {
                min = a;
            }

            else
            {
                min = b;
            }
            Console.WriteLine("Введите третье число, больше 1");
            c = int.Parse(Console.ReadLine());

            if (min > c)
            {
                min = c;
            }

            if (a == b)
            {
                min = a;
                if (c < a)
                { min = c; }
            }
            if (a == c)
            {
                min = a;
                if (b < a)
                { min = b; }
            }
            if (b == c)
            {
                min = b;
                if (c < b)
                { min = c; }
            }

            Console.WriteLine("Минимум равен={0}", min);
            Console.WriteLine("Сравнение с первым числом");

            Console.WriteLine(d);
            Console.WriteLine(e);
            for (int i = 1; ; i++)
            {
                F = d + e; if (F >= a)
                { break; }
                Console.WriteLine(F);
                {
                    d = e;
                    e = F;

                }

            }
            Console.WriteLine("Сравнение со вторым числом");

            d = 0; e = 1;
            Console.WriteLine(d);
            Console.WriteLine(e);
            for (int i = 1; ; i++)
            {
                F = d + e; if (F >= b)
                { break; }
                Console.WriteLine(F);
                {
                    d = e;
                    e = F;
                    if (F >= b)
                    { break; }
                }

            }
            Console.WriteLine("Сравнение с третьим числом");

            d = 0; e = 1;
            Console.WriteLine(d);
            Console.WriteLine(e);
            for (int i = 1; ; i++)
            {
                F = d + e; if (F >= c)
                { break; }
                Console.WriteLine(F);
                {
                    d = e;
                    e = F;
                    if (F >= c)
                    { break; }
                }

            }

        }
    }
}
