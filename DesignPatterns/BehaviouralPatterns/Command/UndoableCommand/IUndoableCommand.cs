namespace DesignPatterns.BehaviouralPatterns.Command.UndoableCommand
{
    public interface IUndoableCommand: ICommand
    {
        void UnExecute();
    }
}