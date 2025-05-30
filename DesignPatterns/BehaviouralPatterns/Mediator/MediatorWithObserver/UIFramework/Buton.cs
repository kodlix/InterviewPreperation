namespace DesignPatterns.BehaviouralPatterns.Mediator.MediatorWithObserver.UIFramework
{
    public class Button: UIControl
    {
        private bool _isEnabled;

        public bool IsEnabled()
        {
            return _isEnabled;
        }

        public void SetEnabled(bool isEnabled)
        {
            _isEnabled = isEnabled;
            NotifyEventHandlers();        }
    }
}