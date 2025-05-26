using System;

namespace DesignPatterns.BehaviouralPatterns.Template.Strategy
{
    public class Coffee: IBeverage
    {
        public void Prepare()
        {
            Brew();
            AddCondiments();
        }
        
        private void Brew()
        {
            Console.WriteLine("Brewing coffee for 3 minutes");
        }
        
        private void AddCondiments()
        {
            if(CustomerWantsCondiments())
                Console.WriteLine("Add cream to coffee");
        }

        private bool CustomerWantsCondiments()
        {
            Console.WriteLine("Would you like cream with your coffee? [y/n]");
            string input = Console.ReadLine();
            return input.ToLower() == "y";
        }
    }
}