using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Creational.Prototype.BadExample
{
    public class Rectangle : Shape
    {
        public int Width { get; set; } = 10;
        public int Height { get; set; } = 5;

        public void Draw()
        {
            System.Console.WriteLine("Drawing rectangle");
        }
    }
}