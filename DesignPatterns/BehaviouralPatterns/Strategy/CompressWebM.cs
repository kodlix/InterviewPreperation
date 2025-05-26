namespace DesignPatterns.BehaviouralPatterns.Strategy
{
    public class CompressWebM: ICompressor
    {
        public void Compress()
        {
            System.Console.WriteLine("Compressing video using WEBM");
        }
    }
}