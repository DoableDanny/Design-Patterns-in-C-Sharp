using ConsoleApp1.src.DesignPatterns.Behavioral.Iterator.GoodExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Iterator.MyTest
{
    public class ShoppingList
    {
        private List<string> _list = new List<string>();
        public void Push(string itemName)
        {
            _list.Add(itemName);
        }

        public List<string> GetList() => _list; 
        public string Pop()
        {
            var last = _list.Last();
            _list.Remove(last);
            return last;
        }

        public IIterator<String> CreateIterator()
        {
            return new ListIterator(this);
        }
    }
}
