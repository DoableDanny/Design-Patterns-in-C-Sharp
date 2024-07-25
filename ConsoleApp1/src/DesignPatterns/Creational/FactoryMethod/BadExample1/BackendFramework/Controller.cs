using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.src.DesignPatterns.Creational.FactoryMethod.BadExample.Blade;

namespace ConsoleApp1.src.DesignPatterns.Creational.FactoryMethod.BadExample.BackendFramework
{
    public class Controller
    {
        public void Render(string fileName, Dictionary<string, object> data)
        {
            var viewEngine = new BladeViewEngine(); // PROBLEM: Controller is tightly coupled to this particular view engine -- not flexible
            var html = viewEngine.Render(fileName, data);
            System.Console.WriteLine(html);
        }
    }
}