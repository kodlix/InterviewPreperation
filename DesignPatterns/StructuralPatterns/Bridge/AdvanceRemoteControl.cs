namespace DesignPatterns.StructuralPatterns.Bridge
{
    public class AdvanceRemoteControl: RemoteControl
    {
        public AdvanceRemoteControl(IDevice device) : base(device)
        {
        }
        
        public void SetChannel(int channel)
        {
            System.Console.WriteLine("Setting channel to " + channel);
        }
    }
}