namespace DesignPatterns.BehaviouralPatterns.Strategy
{
    public class CompressMov: ICompressor
    {
        public void Compress()
        {
            System.Console.WriteLine("Compressing video using MOV");
        }
    }
}