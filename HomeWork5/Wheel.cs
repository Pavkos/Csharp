using System;

namespace HomeWork5
{
    public class Wheel : Detail, IRotatable
    {
        public int NumberWheel { get; private set; }
        private Car ownerCar;
        
        public Wheel(int numberWheel, string name, Car ownerCar)
        {
            this.NumberWheel = numberWheel;
            this.Name = name;
            this.ownerCar = ownerCar;
        }

        public void Move()
        {
            Console.WriteLine("Колесо №{0} машины {1} вращается", NumberWheel, ownerCar.Model);
        }      
    }
}

