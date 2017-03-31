using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 10);
            Console.WriteLine("Название фигуры: {0}", rectangle.Name() );
            Console.WriteLine("Площадь фигуры: {0}", rectangle.Area());
            Console.WriteLine("Периметр фигуры: {0}", rectangle.Perimetr());
            Console.WriteLine();

            Triangle triangle = new Triangle(2, 3, 4);
            Console.WriteLine("Название фигуры: {0}", triangle.Name());
            Console.WriteLine("Площадь фигуры: {0}", triangle.Area());
            Console.WriteLine("Периметр фигуры: {0}", triangle.Perimetr());
            Console.WriteLine();

            Circle circle = new Circle(5);
            Console.WriteLine("Название фигуры: {0}", circle.Name());
            Console.WriteLine("Площадь фигуры: {0}", circle.Area());
            Console.WriteLine("Периметр фигуры: {0}", circle.Perimetr());
            Console.WriteLine();

            

            Sector sector = new Sector(5, 6);
            Console.WriteLine("Название фигуры: {0}", sector.Name());
            Console.WriteLine("Площадь фигуры: {0}", sector.Area());
            Console.WriteLine("Периметр фигуры: {0}", sector.Perimetr());
            Console.Read();
           
        }

    }
    
    
    

}
