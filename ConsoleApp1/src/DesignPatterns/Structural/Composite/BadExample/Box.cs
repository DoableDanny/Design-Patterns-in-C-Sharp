using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Composite.BadExample
{
    public class Box
    {
        private List<object> items = new List<object>();

        public void Add(Object item)
        {
            items.Add(item);
        }

        // This method is UGLY!!! We need polymorphism!!
        public float CalculateTotalPrice()
        {
            float totalPrice = 0;
            foreach (var item in items)
            {
                if (item is Keyboard)
                {
                    totalPrice += ((Keyboard)item).Price; // cast item to Keyboard object then we can get it's Price
                }
                else if (item is Mouse)
                {
                    totalPrice += ((Mouse)item).Price;
                }
                else if (item is Microphone)
                {
                    totalPrice += ((Microphone)item).Price;
                }
                else if (item is Box)
                {
                    totalPrice += ((Box)item).CalculateTotalPrice(); // call CalculateTotalPrice() recursively
                }
            }
            return totalPrice;
        }
    }
}