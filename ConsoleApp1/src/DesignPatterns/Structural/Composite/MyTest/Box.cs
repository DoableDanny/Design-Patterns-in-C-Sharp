using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Composite.MyTest
{
    public class Box :IItem
    {
        List<IItem> _items = new List<IItem>();

        public void AddItem(IItem item)
        {
            _items.Add(item);
        }

        public int GetPrice()
        {
            int totalPrice = 0;
            foreach (var item in _items)
            {
                totalPrice += item.GetPrice();
            }
            return totalPrice;
        }
    }
}
