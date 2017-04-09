using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    public class Car:Detail
    {
        public List<Car> listCar = new List<Car>();
        public static string modelCar;
        private string nameCar;
        public Car()
        {

        }
        public Car(int numberWheel, int numberDoor)
        {
            Wheel wheel = new Wheel(numberWheel);
            Body body = new Body();
            Door door = new Door(numberDoor);
            listCar.Add(wheel);
            listCar.Add(door);
            listCar.Add(body);
        }

        public override int Weight { set; get; }
        public override string Name
        {
            get
            {
                return "Автомобиль";
            }

            set
            {
                nameCar=value;
            }
        }


        public string ModelCar
        {
            set
            {
                modelCar = value;
            }
        }
       
    }
}
