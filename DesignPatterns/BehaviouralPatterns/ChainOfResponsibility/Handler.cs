namespace DesignPatterns.BehaviouralPatterns.ChainOfResponsibility
{
    public abstract class Handler
    {
        private Handler _nextHandler;

        public Handler SetNext(Handler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public void Handle(HttpRequest request)
        {
            if (DoHandle(request))
            {
                return;
            }

            if (_nextHandler != null)
            {
                _nextHandler.Handle(request);
            }
        }

        public abstract bool DoHandle(HttpRequest request);
    }
}