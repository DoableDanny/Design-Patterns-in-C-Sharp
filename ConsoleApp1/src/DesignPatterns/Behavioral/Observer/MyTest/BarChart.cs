using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Observer.MyTest
{
    public class BarChart : IObserver
    {
        private DataSource _dataSource;

        public BarChart(DataSource dataSource)
        {
            _dataSource = dataSource;
        }
        public void Update()
        {
            Console.WriteLine("BarChart updated");
        }
    }
}
