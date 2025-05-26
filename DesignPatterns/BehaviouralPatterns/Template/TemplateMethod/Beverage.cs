using System;

namespace DesignPatterns.BehaviouralPatterns.Template.TemplateMethod
{
    public abstract class Beverage
    {
        public void Prepare()
        {
            BoilWater();
            PourIntoCup();
            Brew();
            AddCondiments();
        }

        protected virtual void AddCondiments() {}

        protected abstract void Brew();

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
        
        private void PourIntoCup()
        {
            Console.WriteLine("Pouring boiled water into cup");
        }
    }
    
    
}