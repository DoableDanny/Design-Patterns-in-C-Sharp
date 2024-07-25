using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Creational.AbstractFactory.GoodExample.Mac
{
    public class MacButton : IButton
    {
        public void Render()
        {
            System.Console.WriteLine("Mac: render button");
        }
    }
}