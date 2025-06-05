namespace DesignPatterns.StructuralPatterns.Bridge
{
    public interface IDevice
    {
        void TurnOn();

        void TurnOff();

         void SetChannel(int channel);
    }
}