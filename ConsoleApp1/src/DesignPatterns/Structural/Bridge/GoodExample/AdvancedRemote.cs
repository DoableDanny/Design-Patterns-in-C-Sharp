using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Bridge.GoodExample
{
    public class AdvancedRemote : RemoteControl
    {
        public AdvancedRemote(Device device) : base(device)
        {
        }

        public void SetChannel(int channel)
        {
            System.Console.WriteLine("Setting channel to " + channel);
        }
    }
}