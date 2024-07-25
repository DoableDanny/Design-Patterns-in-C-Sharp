using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Bridge.BadExample
{
    public abstract class AdvancedRemote : RemoteControl
    {
        public abstract void SetChannel(int channel);
    }
}