namespace DesignPatterns.BehaviouralPatterns.Command.UndoableCommand
{
    public class UndoCommand: ICommand
    {
        private DocHistory _history;

        public UndoCommand(DocHistory history)
        {
            _history = history;
        }

        public void Execute()
        {
            if (_history.Size() > 0)
            {
                var command = _history.Pop();
                command.UnExecute();
            }
        }
    }
}