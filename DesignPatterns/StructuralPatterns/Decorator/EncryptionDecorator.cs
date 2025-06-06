namespace DesignPatterns.StructuralPatterns.Decorator
{
    public class EncryptionDecorator : DataDecorator
    {
        public EncryptionDecorator(IData data) : base(data)
        {
        }

        public override void Save(string data)
        {
            System.Console.WriteLine("Encryping data");
            var encrypted = Encrypt(data);
            base._data.Save(encrypted);
        }

        // This can now be private, encapsulating this code
        private string Encrypt(string data)
        {
            return "$dc&^*()';,,£@%%*(~)`"; // pretend to encrypt data
        }
    }
}