using System;

namespace DesignPatterns.BehaviouralPatterns.Template.Strategy
{
    public class Tea : IBeverage
    {
        public void Prepare()
        {
            Brew();
            AddCondiments();
        }

        private void Brew()
        {
            Console.WriteLine("Brewing tea for 3 minutes");
        }
        
        private void AddCondiments()
        {
            if(CustomerWantsCondiments())
                Console.WriteLine("Add lemon to tea");
        }

        private bool CustomerWantsCondiments()
        {
            Console.WriteLine("Would you like lemon with your tea? [y/n]");
            string input = Console.ReadLine();
            return input.ToLower() == "y";
        }
    }
}