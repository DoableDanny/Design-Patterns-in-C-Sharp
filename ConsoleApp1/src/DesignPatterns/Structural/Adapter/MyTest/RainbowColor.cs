using ConsoleApp1.src.DesignPatterns.Structural.Adapter.MyTest.ThridPartyColorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Adapter.MyTest
{
    public class RainbowColor :IColor 
    {
        private Rainbow _rainbow; // Third party library class
        public RainbowColor(Rainbow rainbow)
        {
            _rainbow = rainbow;
        }
        public void Apply(Video video)
        {
            _rainbow.Setup();
            _rainbow.Update(video);
            Console.WriteLine("Applying Rainbow color"); 
        }
    }
}
