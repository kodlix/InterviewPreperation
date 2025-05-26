using System;

namespace DesignPatterns.BehaviouralPatterns.Template.Strategy
{
    public class BeverageMaker
    {
        private IBeverage _beverage;

        public BeverageMaker(IBeverage beverage)
        {
            _beverage = beverage;
        }
        
        public void SetBeverage(IBeverage beverage)
        {
            _beverage = beverage;
        }
        
        public void MakeBeverage()
        {
            //common operations
            BoilWater();
            PourIntoCup();
            
            //unique operation
            _beverage.Prepare();
        }

        

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