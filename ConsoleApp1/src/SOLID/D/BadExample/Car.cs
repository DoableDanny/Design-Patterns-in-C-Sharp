namespace ConsoleApp1.SOLID.D.BadExample
{
    public class Car
    {
        private Engine engine;

        public Car()
        {
            this.engine = new Engine(); // Direct dependency on Engine class
        }

        public void StartCar()
        {
            engine.Start();
            System.Console.WriteLine("Car started.");
        }
    }
}