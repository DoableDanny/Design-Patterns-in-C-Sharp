using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Iterator.GoodExample
{
    public interface IIterator<T>
    {
        void Next();
        bool HasNext();
        // String Current(); // PROBLEM: what if don't always wanna iterate over strings? E.g. Customers or integers.
        T Current(); // SOLUTION: Use a Generic type
    }
}