namespace DesignPatterns.BehaviouralPatterns.Command.UndoableCommand
{
    public class HtmlDocument
    {
        public string Content { get; set; }

        public void MakeItalic()
        {
            Content = "<a>" + Content + "<a/>";
        }
    }
}