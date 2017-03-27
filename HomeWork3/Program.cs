using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string inputString=Console.ReadLine();            
            WorkforString stringWorker = new WorkforString(inputString);
            Console.WriteLine("Polyndrom {0}", stringWorker.TestPolyndrom());
            Console.WriteLine("Количество слов {0}", stringWorker.Sum());
            Console.WriteLine("Обратная строка {0}", stringWorker.Reverse());
            Console.ReadLine();
        }
    }

    class WorkforString
    {
        private string str;
        public WorkforString(string str)
        {
            this.str = str;
        }

        public bool TestPolyndrom()
        {
            bool polyndrom = true;
            int index = this.str.Length - 1;
            for (int i = 0; i <= index / 2; i++)
            {
                if (this.str[i] != this.str[index - i])
                {
                    polyndrom = false;
                    break;
                }
            }
            return polyndrom;
        }
        public int Sum()
        {
            string[] b = this.str.Split();
            return b.Length;
        }
        public string Reverse()
        {
            char[] arr = this.str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
