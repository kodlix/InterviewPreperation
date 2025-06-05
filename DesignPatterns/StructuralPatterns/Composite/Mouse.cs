namespace DesignPatterns.StructuralPatterns.Composite
{
    public class Mouse: IItem
    {
        private float _price = 20.00F;
        public float GetPrice()
        {
            return _price;
        }
    }
}