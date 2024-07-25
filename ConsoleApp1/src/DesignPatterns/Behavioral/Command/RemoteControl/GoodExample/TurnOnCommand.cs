using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Command.RemoteControl.GoodExample
{
    public class TurnOnCommand : ICommand
    {
        private Light _light;

        public TurnOnCommand(Light light)
        {
            _light = light; // _light can only be set in constructor, so command is immutable (can't be changed once created)
        }

        public void Execute()
        {

            _light.TurnOn(); // business logic is delegated to Light object
        }
    }
}