using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Composite.MyTest
{
    public class Microphone :IItem
    {
        private int _price;

        public Microphone(int price)
        {
            _price = price;
        }

        public int GetPrice()
        {
            return _price;
        }
    }
}
