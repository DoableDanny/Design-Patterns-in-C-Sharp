using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Creational.FactoryMethod.BadExample2.BackendFramework
{
    public class Controller
    {
        public void Render(string fileName, Dictionary<string, object> data, ViewEngine viewEngine)
        {
            var html = viewEngine.Render(fileName, data);
            System.Console.WriteLine(html);
        }
    }
}