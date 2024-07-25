// Base class representing a vehicle
namespace ConsoleApp1.Inheritance
{
  public class Vehicle
  {
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public void Start()
    {
      Console.WriteLine("Vehicle is starting.");
    }

    public void Stop()
    {
      Console.WriteLine("Vehicle is stopping.");
    }
  }
}