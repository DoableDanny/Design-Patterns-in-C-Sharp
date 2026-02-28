using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Iterator.MyTest
{
    public class ListIterator : IIterator<string>
    {
        private ShoppingList _shoppingList;
        private int _index;

        public ListIterator(ShoppingList shoppingList)
        {
            _shoppingList = shoppingList;
        }

        public string Current()
        {
            return _shoppingList.GetList()[_index];
        }

        public bool HasNext()
        {
            return _index < _shoppingList.GetList().Count;
        }

        public void Next()
        {
            _index++;
        }

        public void Reset()
        {
            _index = 0;
        }
    }
}
