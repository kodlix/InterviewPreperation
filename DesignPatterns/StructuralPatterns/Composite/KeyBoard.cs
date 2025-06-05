namespace DesignPatterns.StructuralPatterns.Composite
{
    public class KeyBoard: IItem
    {
        private float _price = 40.00F;
        public float GetPrice()
        {
            return _price;
        }
    }
}