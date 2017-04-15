using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class Matrix
    {
        Random ran = new Random();
        private int line;
        private int column;
        private int numbermultiplication;

        public Matrix(int line, int column, int numbermultiplication)
        {
            this.line = line;
            this.column = column;
            this.numbermultiplication = numbermultiplication;
        }

        public int[,] CreateMatrix(int line,int column)
        {            
            int[,] matrix = new int[line, column];
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[i,j] = ran.Next(-10, 10);
                }
            }
            return matrix;
        }

        public void PrintMatrix(int [,] matrix)
        {
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public int[,] SumMatrix(int[,] matrix1, int[,] matrix2)
        {
            int[,] resultsummatrix = new int[line, column];
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    resultsummatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return resultsummatrix;
        }

        public int[,] MultiplicationNumber(int[,] matrix1,int numbermultiplication)
        {
            int[,] matrix = new int[line, column];
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = matrix1[i, j]* numbermultiplication;
                }
            }
            return matrix;
        }

        public int[,] Multiplication(int[,] matrix1, int[,] matrix2)
        {
            int[,] matrix = new int[line, column];

            for (uint i = 0; i < line; i++)
            {
                for (uint j = 0; j < column; j++)
                {
                    for (uint r = 0; r < column; r++)
                    {
                        matrix[i, j] += matrix1[i, r] * matrix2[r, j];
                    }
                }
            }
            return matrix;
        }



        public void Transpon(int[,] matrix1)
        {
            int[,] matrix = new int[line, column];

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < line; j++)
                {
                    matrix[i, j] = matrix1[j, i];
                    Console.Write(matrix[i, j] + " \t ");
                }
                Console.WriteLine();
            }
        }

        public float Determinant(int[,] matrix)        
        {
            int numRows = matrix.GetLength(0);
            int numCols = matrix.GetLength(1);
            int n = numCols;                                    

            if (numCols != numRows)
            {
                
                Console.WriteLine("Определитель матрицы вычислить не удалось. Матрица не квадратная, а гипердетерминант мы не умеем.");
            };

           
            for (int k = 1; k < n; k++)                       
            {
                for (int i = k; i < n; i++)
                {
                    int C = matrix[i, k - 1] / matrix[k - 1, k - 1];
                    for (int j = 0; j < numCols; j++)
                    {
                        matrix[i, j] -= C * matrix[k - 1, j];
                    }
                }
            };
            float result = 1;
            for (int i = 0; i < n; i++)                         
            {
                result *= matrix[i, i];
            };

            return result;
        }
    }
}
