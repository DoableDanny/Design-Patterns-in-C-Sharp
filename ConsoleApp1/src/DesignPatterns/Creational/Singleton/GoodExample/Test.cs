using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Creational.Singleton.GoodExample
{
    public class Test
    {
        public void Run()
        {
            var settings = AppSettings.GetInstance();
            System.Console.WriteLine(settings.Get("app_creator")); // set app_creator in Main and it will return same value when this Run() method is called
        }
    }
}