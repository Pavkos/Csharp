using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4
{
    class Rectangle : Figure
    {
        double SideA, SideB;
        public Rectangle(double a, double b)
        {
            this.SideA = a;
            this.SideB = b;
        }
        public override double Area()
        {
            return SideA * SideB;
        }
        public override double Perimetr()
        {
            return 2* SideA + 2* SideB;
        }
        public override string Name()
        {
            return "Прямоугольник"; 
        }
    }
}
