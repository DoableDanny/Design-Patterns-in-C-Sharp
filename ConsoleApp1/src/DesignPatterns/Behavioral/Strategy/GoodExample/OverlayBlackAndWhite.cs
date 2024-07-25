using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Strategy.GoodExample
{
    public class OverlayBlackAndWhite : IOverlay
    {
        public void Apply()
        {
            System.Console.WriteLine("Applying black and white overlay");
        }
    }
}