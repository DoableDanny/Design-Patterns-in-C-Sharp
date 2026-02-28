using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Bridge.MyTest
{
    public interface Device
    {
        void TurnOn();

        void TurnOff();

        void SetChannel(int channel);
    }
}
