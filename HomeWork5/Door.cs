using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Door : Car, IDoor
    {
        private int numberDoor;
        private bool OpenOrClose;
        public Door(int numberDoor)
        {
            this.numberDoor = numberDoor;
        }

        public void Open()
        {
            Console.Write($"Дверь № {NumberDoor} машины {modelCar} ");
            Console.Write(OpenOrClose ? "открыта" : "закрыта");
            Console.WriteLine();
            OpenOrClose = !OpenOrClose;
        }

        public int NumberDoor
        {
            get
            {
                return numberDoor;
            }
        }
        public override string Name
        {
            get
            {
                return "Дверь";
            }

        }
    }
}