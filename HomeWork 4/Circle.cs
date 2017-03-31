using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4
{
    class Circle:Figure
    {
        double radius;
        public Circle(double radius)
        {
            this.radius = radius;
            
        }
        public override double Area()
        {
            return Math.PI* Math.Pow(radius, 2);
        }
        public override double Perimetr()
        {
            return 2 * Math.PI * radius; ;
        }
        public override string Name()
        {
            return "Круг";
        }
    }
}
