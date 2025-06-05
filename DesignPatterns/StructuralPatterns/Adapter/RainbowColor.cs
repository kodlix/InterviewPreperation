using DesignPatterns.StructuralPatterns.Adapter.Package;

namespace DesignPatterns.StructuralPatterns.Adapter
{
    public class RainbowColor: IColor
    {
        private Rainbow _rainbow;

        public RainbowColor(Rainbow rainbow)
        {
            _rainbow = rainbow;
        }
        public void Apply(Video video)
        {
            _rainbow.Setup();
            _rainbow.Update();
            System.Console.WriteLine("Applying rainbow color to video");
        }
    }
}