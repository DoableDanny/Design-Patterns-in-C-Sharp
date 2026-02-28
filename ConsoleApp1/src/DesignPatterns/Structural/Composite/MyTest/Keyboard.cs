using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Composite.MyTest
{
    public class Keyboard : IItem
    {
        private int _price;
       
        public Keyboard(int price)
        {
            _price = price;
        }

        public int GetPrice()
        {
            return _price;
        }
    }
}
