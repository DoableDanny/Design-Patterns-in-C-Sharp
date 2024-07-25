using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.src.DesignPatterns.Creational.FactoryMethod.BadExample.BackendFramework;

namespace ConsoleApp1.src.DesignPatterns.Creational.FactoryMethod.BadExample.Blade
{
    public class BladeViewEngine : ViewEngine
    {
        public string Render(string fileName, Dictionary<string, object> data)
        {
            return "View rendered from " + fileName + " by Blade";
        }
    }
}