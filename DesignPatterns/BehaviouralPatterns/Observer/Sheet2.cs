using System;
using System.Collections.Generic;

namespace DesignPatterns.BehaviouralPatterns.Observer
{
    public class Sheet2: IObserver
    {
        private int _total;
        private DataSource _dataSource;

        public Sheet2(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public int GetTotal()
        {
            return _total;
        }

        private int CalculateTotal(List<int> values)
        {
            var sum = 0;
            foreach (var value in values)
            {
                sum += value;
            }
            Console.WriteLine("Total: " + sum);
            return sum;
        }
        public void Update()
        {
            _total = CalculateTotal(_dataSource.GetValues());
        }
    }
}