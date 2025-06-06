namespace DesignPatterns.StructuralPatterns.Decorator
{
    public class CloudData : IData
    {
        private string _url;

        public CloudData(string url)
        {
            _url = url;
        }

        public void Save(string data)
        {
            System.Console.WriteLine($"Saving data '{data}' to cloud at '{_url}'");
        }
    }
}