namespace DesignPatterns.StructuralPatterns.Bridge
{
    public class LgRadio: IDevice
    {
        public void TurnOff()
        {
            System.Console.WriteLine("Turning LG radio off");
        }

        public void TurnOn()
        {
            System.Console.WriteLine("Turning LG radio on");
        }

        public void SetChannel(int channel)
        {
            System.Console.WriteLine("Setting LG radio channel to " + channel);
        }
    }
}