using System;

namespace DesignPatterns.BehaviouralPatterns.ChainOfResponsibility
{
    public class Logger: Handler
    {
        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Logging");
            Console.WriteLine(
                $"User: {request.ValidatedUserName} - Password: {request.ValidatedPassword}");
            return false;
        }
    }
}