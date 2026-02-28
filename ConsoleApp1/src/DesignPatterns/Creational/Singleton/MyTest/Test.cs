using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Creational.Singleton.MyTest
{
    public class Test
    {
        public static void Run()
        {
            var settings = AppSettings.GetInstance();
            System.Console.WriteLine(settings.Get("AppName")); // set app_creator in Main and it will return same value when this Run() method is called
        }
    }
}
