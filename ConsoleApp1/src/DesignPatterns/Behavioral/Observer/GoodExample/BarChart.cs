using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Observer.GoodExample
{
    public class BarChart : Observer
    {
        private DataSource _dataSource;

        public BarChart(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            System.Console.WriteLine("Rendering bar chart with new values");
        }
    }
}