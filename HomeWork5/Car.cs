
using System.Collections.Generic;


namespace HomeWork5
{
    public class Car : Detail
    {
        public List<Detail> ListDetail { get; set; } = new List<Detail>();

        public int Weight { set; get; }

        public string Model { get; set; }

        public Car(int numberWheel, int numberDoor)
        {
             
            for (int i = 0; i < numberWheel; i++)
            {
                Wheel wheel = new Wheel(i,"Pirelli",this);
                ListDetail.Add(wheel);                
            }

            Body body = new Body();
            ListDetail.Add(body);

            for (int i = 0; i < numberDoor; i++)
            {
                Door door = new Door(numberDoor, "ABC", this);
                ListDetail.Add(door);
            }                      
        }                         
    }
}
