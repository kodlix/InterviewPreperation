using System;

namespace DesignPatterns.BehaviouralPatterns.ChainOfResponsibility
{
    public class Authenticator: Handler
    {
        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Authenticating");
            var username = request.GetUserName();
            var password = request.GetPassword();
            return !(username == "johny" && password == "1234");
        }
    }
}