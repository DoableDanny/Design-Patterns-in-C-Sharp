using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Bridge.GoodExample
{
    public class RemoteControl
    {
        private Device _device;

        public RemoteControl(Device device)
        {
            _device = device;
        }

        public void TurnOn()
        {
            _device.TurnOn();
        }

        public void TurnOff()
        {
            _device.TurnOff();
        }

        // other basic remote methods...
    }
}