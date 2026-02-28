using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Iterator.MyTest;

public interface IIterator<T>
{
    void Next();
    bool HasNext();
    void Reset();
    T Current(); // Use generic type T for the current element

}
