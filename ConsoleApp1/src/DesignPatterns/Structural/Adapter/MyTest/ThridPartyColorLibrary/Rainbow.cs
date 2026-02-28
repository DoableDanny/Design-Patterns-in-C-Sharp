using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Adapter.MyTest.ThridPartyColorLibrary
{
    public class Rainbow
    {
        public void Setup()
        {
            System.Console.WriteLine("Setting up rainbow filter");
        }

        public void Update(Video video)
        {
            System.Console.WriteLine("Applying rainbow filter to video");
        }
    }
}
