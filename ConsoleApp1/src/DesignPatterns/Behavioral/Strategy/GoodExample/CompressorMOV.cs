using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Strategy.GoodExample
{
public class CompressorMOV : ICompressor
{
    public void Compress()
    {
        System.Console.WriteLine("Compressing video using MOV");
    }
}
}