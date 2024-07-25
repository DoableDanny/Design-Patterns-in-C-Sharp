using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.src.DesignPatterns.Structural.Adapter.ThirdPartyColorLibrary;

namespace ConsoleApp1.src.DesignPatterns.Structural.Adapter
{
    // This class does the same thing as RainbowColor, but uses inheritance, rather than composition. With inheritance,
    // the Rainbow methods can be called directly.
    // Problem: this approach isn't as flexible as using composition, because, in C#, a class can only extend one class; so
    // if Color was an abstract class, we wouldn't be able to extend it. In this case, we're OK, because Color is an interface,
    // but you can see that inheritance is less flexible than composition, and therefore composition should be preferred.
    public class RainbowAdapter : Rainbow, Color
    {
        public void Apply(Video video)
        {
            Setup();
            Update(video);
        }
    }
}