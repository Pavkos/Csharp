using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    public class Door : Detail, IDoor
    {
        private int numberDoor;
        private bool isopen;
        public int NumberDoor { get; private set; }
        private Car ownerCar;

        public Door(int numberDoor, string Name,Car ownerCar)
        {
            this.numberDoor = numberDoor;
            this.Name = Name;
            this.ownerCar = ownerCar;
        }

        public void Open()
        {
            Console.Write($"Дверь № {NumberDoor} машины {ownerCar.Model} ");
            Console.Write(isopen ? "открыта" : "закрыта");
            Console.WriteLine();
            isopen = !isopen;
        }

       


    }
}