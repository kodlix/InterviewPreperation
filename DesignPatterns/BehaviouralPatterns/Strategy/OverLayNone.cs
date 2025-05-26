using System;

namespace DesignPatterns.BehaviouralPatterns.Strategy
{
    public class OverLayNone : IOverlay
    {
        public void Apply()
        {
            Console.WriteLine("Not applying overlay");
        }
    }
}