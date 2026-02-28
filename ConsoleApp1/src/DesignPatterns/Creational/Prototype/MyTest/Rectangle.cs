using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Creational.Prototype.MyTest
{
    public class Rectangle : IShape
    {
        public int Width { get; set; } = 10;
        public int Height { get; set; } = 5;

        public void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }
        public IShape Duplicate()
        {
            var newRectangle = new Rectangle();
            newRectangle.Width = this.Width;
            newRectangle.Height = this.Height;
            
            return newRectangle;
        }

        public string GetShapeInfo()
        {
            return $"Rectangle with width: {Width} and height {Height}";
        }   
    }
}
