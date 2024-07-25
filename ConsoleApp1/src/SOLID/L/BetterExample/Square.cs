
namespace ConsoleApp1.SOLID.L.BetterExample
{
  public class Square : Shape
  {
    private double sideLength;

    public double SideLength
    {
      get => sideLength;
      set
      {
        sideLength = value;
      }
    }

    public override double Area => sideLength * sideLength;
  }
}