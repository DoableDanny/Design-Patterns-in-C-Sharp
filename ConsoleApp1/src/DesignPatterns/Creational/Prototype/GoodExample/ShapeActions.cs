using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Creational.Prototype.GoodExample
{
    public class ShapeActions
    {
        public Shape Duplicate(Shape shape)
        {
            System.Console.WriteLine("Duplicating shape");
            return shape.Duplicate();
        }
    }
}