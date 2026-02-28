using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Bridge.MyTest
{
    public class LGRadio : Device
    {
        public void TurnOff()
        {
            System.Console.WriteLine("Turning LG radio off");
        }

        public void TurnOn()
        {
            System.Console.WriteLine("Turning LG radio on");
        }

        public void SetChannel(int channel)
        {
            System.Console.WriteLine("Setting LG radio channel to " + channel);
        }
    }
}
