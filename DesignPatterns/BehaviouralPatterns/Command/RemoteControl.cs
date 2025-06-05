namespace DesignPatterns.BehaviouralPatterns.Command
{
    public class RemoteController
    {
        private ICommand _command;

        public RemoteController(ICommand command)
        {
            _command = command;
        }

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PressButton()
        {
            _command.Execute();
        }
    }
}