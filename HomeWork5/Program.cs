﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Ferrari = new Car(4, 5);
            

            Ferrari.Model = "ModelA";

            foreach (var i in Ferrari.ListDetail)
            {
                (i as IRotatable)?.Move();
                (i as IDoor)?.Open();
            }

            Console.Read();

        }

    }
}   
    



