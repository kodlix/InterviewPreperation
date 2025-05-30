using System;

namespace DesignPatterns.BehaviouralPatterns.Observer
{
    public class Barchart: IObserver
    {
        private DataSource _dataSource;
       
        public Barchart(DataSource dataSource)
        {
            _dataSource = dataSource;
        }
        
        public void Update()
        {
            Console.WriteLine("Rendering barchart with new values. ");
        }
    }
}