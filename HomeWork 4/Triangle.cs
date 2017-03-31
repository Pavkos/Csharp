using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4
{
    class Triangle:Figure
    {
        double SideA, SideB,SideC,polperimetr;
        public Triangle(double a, double b,double c)
        {
            this.SideA = a;
            this.SideB = b;
            this.SideC = c;
        }
        public override double Area()
        {
            polperimetr = Perimetr()/2;
            return Math.Sqrt(polperimetr*(polperimetr - SideA)*(polperimetr - SideB)*(polperimetr - SideC));
        }
        public override double Perimetr()
        {            
            return SideA+SideB+SideC;
        }
        public override string Name()
        {
            return "Треугольник";
        }
    }
}
