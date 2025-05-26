namespace DesignPatterns.BehaviouralPatterns.Strategy
{
    public class CompressMp4: ICompressor
    {
        public void Compress()
        {
            System.Console.WriteLine("Compressing video using MP4");
        }
    }
}