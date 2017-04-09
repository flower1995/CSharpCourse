using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк для матрицы");
            int numberOfLines = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов для матрицы");
            int numberOfColumns = int.Parse(Console.ReadLine());

            Matrix matr1 = new Matrix(numberOfLines, numberOfColumns);
            Matrix matr2 = new Matrix(numberOfLines, numberOfColumns);

            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    Console.Write(matr1.matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int[,] resultsumMatr1andMatr2 = matr1.Sum(matr2.matrix);
            Console.WriteLine();

            Console.WriteLine("Введите число для его сложения с матрицей");
            int number = int.Parse(Console.ReadLine());

            int[,] multiplyOnNumber = matr1.matrix;


        }
    }
}

