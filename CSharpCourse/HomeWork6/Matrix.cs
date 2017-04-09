using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
        public class Matrix
        {
            private int numberLines;
            private int numberColumns;
            public int[,] matrix;
            Random ran = new Random((int)DateTime.Now.Ticks);
            public Matrix(int numberLines, int numberColumns)
            {
                this.numberLines = numberLines;
                this.numberColumns = numberColumns;
                matrix = primerMatrix();
            }
            private int[,] primerMatrix()
            {
                int[,] array = new int[numberLines, numberColumns];

                for (int i = 0; i < numberLines; i++)
                {
                    for (int j = 0; j < numberColumns; j++)
                    {
                        array[i, j] = ran.Next(-100, 100);
                    }
                }
                return array;
            }

            public int[,] Sum(int[,] matrix2)
            {
                int[,] arrayResult = new int[numberLines, numberColumns];

                for (int i = 0; i < numberLines; i++)
                {
                    for (int j = 0; i < numberColumns; j++)
                    {
                        arrayResult[i, j] = matrix[i, j] + matrix2[i, j];
                    }
                }
                return arrayResult;
            }
            //public int[,] SumWithNumber(int number) - ?невозможно сложить матрицу с числом?
            //{
            //    int[,] arraySumWithNumber = new int[numberLines, numberColumns];

            //    for (int i = 0; i < numberLines; i++)
            //    {
            //        for (int j = 0; i < numberColumns; j++)
            //        {
            //            arraySumWithNumber[i, j] = matrix[i, j] + number;
            //        }
            //    }
            //    return arraySumWithNumber;
            //}

            public int[,] Multiply(int[,] matrix3)
            {
                int[,] arrayMultiply = new int[numberLines, numberColumns];
                for (int i = 0; i < numberLines; i++)
                {
                    for (int j = 0; i < numberColumns; j++)
                    {
                        for (int r = 0; i < numberColumns; i++)
                        {
                            arrayMultiply[i, j] += matrix[i, r] * matrix3[r, j];
                        }
                    }
                }
                return arrayMultiply;

            }
            public int[,] MultiplyOnNumber(int number)
            {
                for (int i = 0; i < numberLines; i++)
                {
                    for (int j = 0; i < numberColumns; j++)
                    {
                        matrix[i, j] = matrix[i, j] * number;
                    }
                }
                return matrix;
            }
            public int[,] Transpose()
            {
                int[,] trans = new int[numberLines, numberColumns];

                for (int i = 0; i < numberLines; i++)
                {
                    for (int j = 0; j < numberColumns; j++)
                    {
                        trans[i, j] = matrix[j, i];
                    }
                }
                return matrix;
            }
        }
    }

