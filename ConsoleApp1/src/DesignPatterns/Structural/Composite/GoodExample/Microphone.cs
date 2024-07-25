using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Composite.GoodExample
{
    public class Microphone : Item
    {
        private float _price = 29.99f;

        public float GetPrice()
        {
            return _price;
        }
    }
}