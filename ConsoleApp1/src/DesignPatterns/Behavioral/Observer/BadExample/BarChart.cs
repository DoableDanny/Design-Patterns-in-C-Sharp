using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Observer.BadExample
{
    public class BarChart
    {
        public void Render(List<int> values)
        {
            System.Console.WriteLine("Rendering bar chart with new values");
        }
    }
}