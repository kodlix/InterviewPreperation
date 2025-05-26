using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.BehaviouralPatterns.Iterator
{
    public class ShoppingList
    {
        private List<string> _list = new List<string>();

        public void Push(string itemName)
        {
            _list.Add(itemName);
        }

        public string Pop()
        {
            var last = _list.Last();
            _list.Remove(last);
            return last;
        }

        public List<string> GetList()
        {
            return _list;
        }
        
        public IIterator<string> CreateIterator()
        {
            return new ListIterator(this);
        }

        private class ListIterator: IIterator<string>
        {
            private ShoppingList _shoppingList;
            private int _index;

            public ListIterator(ShoppingList shoppingList)
            {
                _shoppingList = shoppingList;
            }
            
            public void Next()
            {
                _index++;
            }

            public bool HasNext()
            {
                return _index < _shoppingList._list.Count;
            }

            public string Current()
            {
                return _shoppingList._list[_index];
            }
        }
    }
}