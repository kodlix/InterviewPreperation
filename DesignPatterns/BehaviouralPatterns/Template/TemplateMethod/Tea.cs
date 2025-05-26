using System;

namespace DesignPatterns.BehaviouralPatterns.Template.TemplateMethod
{
    public class Tea : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Brewing tea for 3 minutes");
        }
        
        protected override void AddCondiments()
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