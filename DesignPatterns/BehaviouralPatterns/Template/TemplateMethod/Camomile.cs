using System;

namespace DesignPatterns.BehaviouralPatterns.Template.TemplateMethod
{
    public class Camomile: Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Brewing camomile for 3 minutes");
        }
    }
}