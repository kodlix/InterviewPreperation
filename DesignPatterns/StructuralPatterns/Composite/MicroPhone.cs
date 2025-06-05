namespace DesignPatterns.StructuralPatterns.Composite
{
    public class MicroPhone: IItem
    {
        private float _price = 60.00F;
        public float GetPrice()
        {
            return _price;
        }
    }
}