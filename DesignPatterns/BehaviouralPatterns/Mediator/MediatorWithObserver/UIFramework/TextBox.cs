namespace DesignPatterns.BehaviouralPatterns.Mediator.MediatorWithObserver.UIFramework
{
    public class TextBox: UIControl
    {
        private string _text = "";

        public string GetText()
        {
            return _text;
        }

        public void SetText(string text)
        {
            _text = text;
            NotifyEventHandlers();
        }
    }
}