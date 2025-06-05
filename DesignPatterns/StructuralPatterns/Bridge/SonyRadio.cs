namespace DesignPatterns.StructuralPatterns.Bridge
{
    public class SonyRadio: IDevice
    {
        public void TurnOff()
        {
            System.Console.WriteLine("Turning Sony radio off");
        }

        public void TurnOn()
        {
            System.Console.WriteLine("Turning Sony radio on");
        }

        public void SetChannel(int channel)
        {
            System.Console.WriteLine("Setting Sony radio channel to " + channel);
        }
    }
}