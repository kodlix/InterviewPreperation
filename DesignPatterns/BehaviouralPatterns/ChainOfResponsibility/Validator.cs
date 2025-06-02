using System;

namespace DesignPatterns.BehaviouralPatterns.ChainOfResponsibility
{
    public class Validator: Handler
    {
        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Validating");
            var username = request.GetUserName();
            var password = request.GetPassword();
            
            //Trim whitespace
            request.ValidatedUserName = username.Trim();
            request.ValidatedPassword = password.Trim();

            return request.ValidatedUserName == "" || request.ValidatedPassword == "";
        }
    }
}