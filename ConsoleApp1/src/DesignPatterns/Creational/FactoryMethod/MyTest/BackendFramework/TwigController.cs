using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.src.DesignPatterns.Creational.FactoryMethod.MyTest.TwigFramwork;

namespace ConsoleApp1.src.DesignPatterns.Creational.FactoryMethod.MyTest.BackendFramework
{
    public class TwigController : Controller
    {
        protected override ViewEngine CreateViewEngine()
        {
            return new TwigViewEngine();
        }
    }
}