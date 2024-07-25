using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Creational.Singleton.BadExample
{
    public class Test
    {
        public void Run()
        {
            var settingsElsewhere = new AppSettings();
            System.Console.WriteLine(settingsElsewhere.Get("app_name")); // null -- we need to use Singleton pattern to ensure a single instance of AppSettings is maintained throughout our app
        }
    }
}