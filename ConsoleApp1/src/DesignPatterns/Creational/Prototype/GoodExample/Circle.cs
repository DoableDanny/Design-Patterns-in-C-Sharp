using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Creational.Prototype.GoodExample
{
    public class Circle : Shape
    {
        public int Radius { get; set; } = 5; // give a default radius of 5 for newly-created circles

        public void Draw()
        {
            System.Console.WriteLine("Drawing circle");
        }

        public Shape Duplicate()
        {
            var newCircle = new Circle();
            newCircle.Radius = Radius;
            return newCircle;
        }
    }
}