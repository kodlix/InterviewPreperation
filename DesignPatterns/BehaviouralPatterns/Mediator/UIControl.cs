namespace DesignPatterns.BehaviouralPatterns.Mediator
{
    public class UIControl
    {
        protected DialogBox _owner;

        public UIControl(DialogBox owner)
        {
            _owner = owner;
        }
    }
}