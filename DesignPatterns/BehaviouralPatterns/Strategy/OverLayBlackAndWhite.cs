using System;

namespace DesignPatterns.BehaviouralPatterns.Strategy
{
    public class OverLayBlackAndWhite : IOverlay
    {
        public void Apply()
        {
            Console.WriteLine("Applying overlay of Black and White");
        }
    }
}