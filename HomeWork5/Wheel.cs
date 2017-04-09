using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    public class Wheel : Car, IRotatable
    {
        private int numberWheel;
        public Wheel(int numberWheel)
        {
            this.numberWheel = numberWheel;
        }

        public void Move()
        {
            Console.WriteLine("Колесо №{0} машины {1} вращается", NumberWheel, modelCar);
        }
        public int NumberWheel
        {
            get
            {
                return numberWheel;
            }
        }
        public override string Name
        {
            get
            {
                return "Колесо";
            }
        }
    }
}

