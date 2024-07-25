
namespace ConsoleApp1.SOLID.L.BadExample
{
    public class Rectangle : Shape
    {
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }

        public override double Area => Width * Height;
    }
}