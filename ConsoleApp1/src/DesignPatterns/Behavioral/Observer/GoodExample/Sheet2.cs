using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Observer.GoodExample
{
    public class Sheet2 : Observer
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

        public void Update()
        {
            var sum = CalculateTotal(_dataSource.GetValues());
            System.Console.WriteLine("Total: " + sum);
            _total = sum;
        }

        private int CalculateTotal(List<int> values)
        {
            var sum = 0;
            foreach (var value in values)
            {
                sum += value;
            }
            return sum;
        }
    }
}
