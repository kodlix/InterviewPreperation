namespace DesignPatterns.BehaviouralPatterns.ChainOfResponsibility
{
    public class WebServer
    {
        private Handler _handler;

        public WebServer(Handler handler)
        {
            _handler = handler;
        }

        public void Handler(HttpRequest request)
        {
            _handler.Handle(request);
        }
    }
}