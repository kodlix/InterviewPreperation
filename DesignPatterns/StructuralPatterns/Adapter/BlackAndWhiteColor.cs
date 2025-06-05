namespace DesignPatterns.StructuralPatterns.Adapter
{
    public class BlackAndWhiteColor: IColor
    {
        public void Apply(Video video)
        {
            System.Console.WriteLine("Applying black and white color to video");
        }
    }
}