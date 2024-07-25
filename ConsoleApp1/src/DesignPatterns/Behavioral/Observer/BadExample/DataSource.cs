using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Observer.BadExample
{
    public class DataSource
    {

        private List<int> _values = new List<int>();
        private List<Object> _dependents = new List<Object>();

        public List<int> GetValues()
        {
            return _values;
        }

        public void SetValues(List<int> values)
        {
            _values = values;


            // We now need to update our dependent object
            foreach (var dependent in _dependents)
            {
                // This is gonna be VERY messy if we end up with lots of dependents!!
                if (dependent is Sheet2)
                {
                    (dependent as Sheet2).CalculateTotal(_values);
                }
                else if (dependent is BarChart)
                {
                    (dependent as BarChart).Render(_values);
                }
            }
        }

        public void AddDependent(Object dependent)
        {
            _dependents.Add(dependent);
        }

        public void RemoveDependent(Object dependent)
        {
            _dependents.Remove(dependent);
        }
    }
}

