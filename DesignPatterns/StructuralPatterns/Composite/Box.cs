using System.Collections.Generic;

namespace DesignPatterns.StructuralPatterns.Composite
{
    public class Box: IItem
    {
        private List<IItem> _items = new List<IItem>();


        public void Add(IItem item)
        {
            _items.Add(item);
        }
       
        public float GetPrice()
        {
            float totalPrice = 0.00F;
            foreach (var item in _items)
            {
                totalPrice += item.GetPrice();
            }

            return totalPrice;
        }
    }
}