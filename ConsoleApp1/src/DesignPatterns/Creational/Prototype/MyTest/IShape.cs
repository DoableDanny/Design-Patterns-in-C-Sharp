using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Creational.Prototype.MyTest
{
    public interface IShape
    {
        void Draw();
        IShape Duplicate();
        string GetShapeInfo();
    }
}
