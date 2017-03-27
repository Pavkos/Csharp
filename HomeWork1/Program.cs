using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int length;
        string[] Number = new string[3];
        Console.WriteLine("Введите три числа! Только через пробел, иначе не заработает");
        Number = Console.ReadLine().Split();
        int[] Min = new int[3];
        for (int i = 0; i < 3; i++)
            Min[i] = int.Parse(Number[i]);
        Array.Sort(Min);
        Console.WriteLine("Наименьшее {0}", Min[0]);
        for (int i = 0; i < 3; i++)
        {
            length = int.Parse(Number[i]);
            Fibonachi(length);
        }
        Console.ReadLine();

    }
    static void Fibonachi(int length)
    {
        int f1 = 0;
        int f2 = 1;
        int sum = 0;
        int i = 0;
        string sum2 = null;
        do
        {
            sum2 = sum2 + Convert.ToString(f1);

            sum = f1 + f2;
            f1 = f2;
            f2 = sum;
        } while (f1 < length);
        Console.WriteLine(sum2);
    }
}

