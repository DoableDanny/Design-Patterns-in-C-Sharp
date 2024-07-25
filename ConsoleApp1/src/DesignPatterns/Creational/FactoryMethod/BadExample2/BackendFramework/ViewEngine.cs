using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Creational.FactoryMethod.BadExample2.BackendFramework
{
    public interface ViewEngine
    {
        string Render(string fileName, Dictionary<string, object> data);
    }
}