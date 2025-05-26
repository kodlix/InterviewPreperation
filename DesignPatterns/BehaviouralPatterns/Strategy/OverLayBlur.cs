using System;

namespace DesignPatterns.BehaviouralPatterns.Strategy
{
    public class OverLayBlur : IOverlay
    {
        public void Apply()
        {
            Console.WriteLine("Applying overlay of Blur");
        }
    }
}