using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4
{
    class Sector:Figure
    {
        double radius, corner;
        public Sector(double radius,double corner)
        {
            this.radius = radius;
            this.corner = corner;

        }
        public override double Area()
        {
            return (corner * Math.Pow(radius, 2))/2;
        }
        public override double Perimetr()
        {
            return (corner+2)*radius; ;
        }
        public override string Name()
        {
            return "Сектор";
        }

    }
}
