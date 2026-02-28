using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Creational.Prototype.MyTest
{
    public class ShapeActions
    {
        public IShape Duplicate(IShape shape)
        {
            Console.WriteLine($"Duplicating shape { shape.GetShapeInfo() } ");
            return shape.Duplicate();
        }
    }
}
