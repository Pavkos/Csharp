using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint arrayLength;
            if (!Utils.TryEnterNumberFromConsole(out arrayLength))
            {
                Console.Read();
                return;
            }
            double[] array = new double[arrayLength];
            Random random = new Random(100);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.NextDouble()*100;
            }
            for (int j = array.Length-1; j >0; j--)
            {
                for (int i = 0; i <j; i++)                
                {
                    if (array[i] > array[i + 1])
                    {
                        double temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }

            }

            PrintArray(array);
            Console.ReadLine();

        }
        static void PrintArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i].ToString("0.00") + " ");
            }
        }

    }
}
