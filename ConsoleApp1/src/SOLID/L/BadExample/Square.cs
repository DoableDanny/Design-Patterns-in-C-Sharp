
namespace ConsoleApp1.SOLID.L.BadExample
{
    public class Square : Rectangle
    {
        public override double Width
        {
            get => base.Width;
            set => base.Width = base.Height = value;
        }

        public override double Height
        {
            get => base.Height;
            set => base.Height = base.Width = value;
        }
    }
}