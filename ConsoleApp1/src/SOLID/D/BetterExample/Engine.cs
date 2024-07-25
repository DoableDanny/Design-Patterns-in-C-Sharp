
namespace ConsoleApp1.SOLID.D.BetterExample
{
public class Engine : IEngine // our "low-level" module
{
    public void Start()
    {
        System.Console.WriteLine("Engine started.");
    }
}
}