namespace DesignPatterns.BehaviouralPatterns.Command
{
    public class DimCommand
    {
        private Light _light;

        public DimCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.Dim();
        }
    }
}