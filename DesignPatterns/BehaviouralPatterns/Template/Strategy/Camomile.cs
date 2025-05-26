using System;

namespace DesignPatterns.BehaviouralPatterns.Template.Strategy
{
    public class Camomile: IBeverage
    {
        public void Prepare()
        {
            Brew();
        }
        
        private void Brew()
        {
            Console.WriteLine("Brewing camomile for 3 minutes");
        }
    }
}