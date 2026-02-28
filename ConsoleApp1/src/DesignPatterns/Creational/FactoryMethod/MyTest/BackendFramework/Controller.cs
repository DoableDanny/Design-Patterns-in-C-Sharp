using ConsoleApp1.src.DesignPatterns.Creational.FactoryMethod.MyTest.Blade;

namespace ConsoleApp1.src.DesignPatterns.Creational.FactoryMethod.MyTest.BackendFramework
{
    public abstract class Controller
    {
        public void Render(string fileName, Dictionary<string, object> data)
        {
            var viewEngine = CreateViewEngine();
            var html = viewEngine.Render(fileName, data);
            System.Console.WriteLine(html);
        }

        // By default, the view engine for our framework will be Blade
        protected virtual ViewEngine CreateViewEngine()
        {
            return new BladeViewEngine();
        }

        // Note that we could also implement our template method as an abstract method, and so providing no default view engine, and forcing the developer to select one.
        // protected abstract ViewEngine CreateViewEngine();
    }
}