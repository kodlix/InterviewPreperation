namespace DesignPatterns.BehaviouralPatterns.Command.UndoableCommand
{
    public class ItalicCommand: IUndoableCommand
    {
        private HtmlDocument _doc;
        private string _prevContent = "";
        private DocHistory _history;

        public ItalicCommand(HtmlDocument doc, DocHistory history)
        {
            _doc = doc;
            _history = history;
        }
        public void Execute()
        {
            _prevContent = _doc.Content;
            _doc.MakeItalic();
            _history.Push(this);
        }

        public void UnExecute()
        {
            _doc.Content = _prevContent;
        }
    }
}