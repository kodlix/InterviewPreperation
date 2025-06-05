namespace DesignPatterns.StructuralPatterns.Bridge
{
    public class RemoteControl
    {
        private IDevice _device;

        public RemoteControl(IDevice device)
        {
            _device = device;
        }

        public void TurnOn()
        {
            _device.TurnOn();
        }

        public void TurnOff()
        {
            _device.TurnOff();
        }

        // other basic remote methods...
    }
}