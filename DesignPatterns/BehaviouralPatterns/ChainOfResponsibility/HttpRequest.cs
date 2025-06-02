namespace DesignPatterns.BehaviouralPatterns.ChainOfResponsibility
{
    public class HttpRequest
    {
        private string _userName;
        private string _password;
        public string ValidatedUserName { get; set; }
        public string ValidatedPassword { get; set; }

        public string GetUserName()
        {
            return _userName;
        }

        public string GetPassword()
        {
            return _password;
        }
        
        public HttpRequest(string userName, string password)
        {
            _userName = userName;
            _password = password;
        }
        
        
    }
}