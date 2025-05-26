using System;

namespace DesignPatterns.BehaviouralPatterns.Command
{
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Turn the light ON");
        }
        
        public void TurnOff()
        {
            Console.WriteLine("Turn the light OFF");
        }
        
        public void Dim()
        {
            Console.WriteLine("Dim the light");
        }
    }
}