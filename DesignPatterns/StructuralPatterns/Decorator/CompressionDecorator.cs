namespace DesignPatterns.StructuralPatterns.Decorator
{
    public class CompressionDecorator : DataDecorator
    {
        public CompressionDecorator(IData data) : base(data)
        {
        }

        public override void Save(string data)
        {
            System.Console.WriteLine("Compressing data");
            var compressed = Compress(data);
            base._data.Save(compressed);
        }

        private string Compress(string data)
        {
            return data.Substring(0, 9); // pretend to compress data
        }
    }
}