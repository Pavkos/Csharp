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
            Console.WriteLine("Введите число столбцов в  матрицах");
            int column = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число строк в матрицах");
            int line = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите на какое число умножать матрицу");
            int numbermultiplication = int.Parse(Console.ReadLine());

            Matrix A = new Matrix(line, column, numbermultiplication);

            Console.WriteLine("Первая матрица");
            int[,] a = A.CreateMatrix(line,column);
            A.PrintMatrix(a);

            Console.WriteLine("Вторая матрица");
            int[,] b = A.CreateMatrix(line, column);
            A.PrintMatrix(b);

            Console.WriteLine("Перемножение матриц");
            int[,] d = A.Multiplication(a, b);
            A.PrintMatrix(d);    

            Console.WriteLine("Умножение первой матрицы на число");
            int[,] c = A.MultiplicationNumber(a, numbermultiplication);
            A.PrintMatrix(c);

            Console.WriteLine("Результат сложения матриц");
            int[,] summatrix = A.SumMatrix(a, b);
            A.PrintMatrix(summatrix);

            Console.WriteLine("Определитель матрицы a {0}", A.Determinant(a));
            Console.WriteLine("Определитель матрицы b {0}", A.Determinant(b));
            Console.WriteLine("Транспонирование первой матрицы ");
            A.Transpon(a);


            Console.ReadLine();
        }
    }
}
