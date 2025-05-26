using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.BehaviouralPatterns.Command.UndoableCommand
{
    public class DocHistory
    {
        private List<IUndoableCommand> _commands = new List<IUndoableCommand>();

        public void Push(IUndoableCommand command)
        {
            _commands.Add(command);
        }
        
        public IUndoableCommand Pop()
        {
            var last = _commands.Last();
            _commands.Remove(last);
            return last;
        }

        public int Size()
        {
            return _commands.Count;
        }
    }
}