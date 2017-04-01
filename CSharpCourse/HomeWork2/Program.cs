using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int number = int.Parse(Console.ReadLine());
            int x;
            int[] myArr = new int[number];
            Random ran = new Random();
            Console.WriteLine("Массив случайных чисел:");
            for (int i = 0; i < number; i++)
            {
                myArr[i] = ran.Next(-100, 100); // для удобства, чтобы не работать с большими числами
                Console.WriteLine(myArr[i]);
            }
            Console.WriteLine("Массив отсортированных чисел:");
            for (int i = 0; i < number; i++)
            {
                for (int j = number - 1; j > i; j--)
                    if (myArr[j - 1] > myArr[j])
                    {
                        x = myArr[j - 1]; myArr[j - 1] = myArr[j]; myArr[j] = x;
                    }
                Console.WriteLine(myArr[i]);
            }
        }
    }
}
