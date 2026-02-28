using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Adapter.MyTest
{
    public class RainbowAdaptor : IColor
     { 
        public void Apply(Video video)
        {
            Console.WriteLine("Applying Rainbow");
        }
    }
}
