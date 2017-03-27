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
            int number;
            Random ran = new Random();
            Console.WriteLine("Введите число");
            if (!Int32.TryParse(Console.ReadLine(), out number))
                Console.WriteLine("Это не число! Мой алгоритм не проведёшь");
            int[] Arr = new int[number];
            for (int i = 0; i < number; i++)
            {
                Arr[i] = ran.Next(1, 15);
                Console.Write("{0} " , Arr[i]);
            }
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number - i - 1; j++)
                {
                    if (Arr[j] > Arr[j + 1])
                    {
                        int temp = Arr[j];
                        Arr[j] = Arr[j + 1];
                        Arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine();
            foreach (int var in Arr)
                Console.Write("{0} ", var);
        }
    }
}


