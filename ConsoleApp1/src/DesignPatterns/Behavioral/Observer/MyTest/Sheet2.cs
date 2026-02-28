using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Observer.MyTest
{
    public class Sheet2 : IObserver
    {
        private int _total;
        private DataSource _dataSource;

        public int GetTotal()
        {
            return _total;
        }

        public Sheet2(DataSource dataSource)
        {
            _dataSource = dataSource;
        }
        public int CalculateTotal(List<int> values)
        {
            var sum = 0;
            foreach (var value in values)
            {
                sum += value;
            }
            return sum;
        }
        public void Update()
        {
            _total = CalculateTotal(_dataSource.GetValues());
            Console.WriteLine($"Sheet2 updated to { _total } ");
        }
    }
}
