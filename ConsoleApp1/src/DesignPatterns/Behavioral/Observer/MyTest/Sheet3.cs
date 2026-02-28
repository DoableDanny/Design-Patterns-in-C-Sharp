using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Observer.MyTest
{
    public class Sheet3 : IObserver
    {
        private int _average;
        private DataSource _dataSource;

        public int GetTotal()
        {
            return _average;
        }

        public Sheet3(DataSource dataSource)
        {
            _dataSource = dataSource;
        }
        public int CalculateAverage(List<int> values)
        {
            var sum = 0;
            foreach (var value in values)
            {
                sum += value;
            }
            return sum  / values.Count;
        }
        public void Update()
        {
            _average = CalculateAverage(_dataSource.GetValues());
            Console.WriteLine($"Sheet3 updated to { _average} ");
        }
    }
}
