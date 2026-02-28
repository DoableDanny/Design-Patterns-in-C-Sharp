using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Creational.Prototype.MyTest
{
    public class Circle : IShape
    {
        public int Radius { get; set; } = 5;

        public void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }
        public string GetShapeInfo()
        {
            return $"Circle with radius: {Radius}";
        }

        public IShape Duplicate()
        {
            var newCircle = new Circle();
            newCircle.Radius = Radius;

            return newCircle;
        }
    }
}
