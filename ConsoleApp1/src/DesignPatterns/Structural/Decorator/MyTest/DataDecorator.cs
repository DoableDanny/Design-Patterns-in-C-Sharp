using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Decorator.MyTest
{
    public abstract class DataDecorator : IData
    {
        protected IData _data;

        public DataDecorator(IData data)
        {
            _data = data;
        }

        public abstract void SaveData(string data);
       
    }
}
