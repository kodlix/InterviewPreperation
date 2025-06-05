using DesignPatterns.StructuralPatterns.Adapter.Package;

namespace DesignPatterns.StructuralPatterns.Adapter
{
    public class RainbowAdapter: Rainbow, IColor
    {
        public void Apply(Video video)
        {
            Setup();
            Update();
            System.Console.WriteLine("Applying rainbow color to video");        }
    }
}