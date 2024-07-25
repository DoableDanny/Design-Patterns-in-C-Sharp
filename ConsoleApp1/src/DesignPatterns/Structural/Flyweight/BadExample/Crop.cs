using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Flyweight.BadExample
{
    public class Crop
    {
        private int _x; // 4 bytes
        private int _y; // 4 bytes
        private CropType _cropType; // 4 bytes
        private byte[] _icon; // 40 KB -> if there are 1000 points to render, that's 40 MB of memory. Many mobile devices would struggle with that.

        public Crop(int x, int y, CropType cropType, byte[] icon)
        {
            _x = x;
            _y = y;
            _cropType = cropType;
            _icon = icon;
        }

        public void Render()
        {
            System.Console.WriteLine($"Drawing {_cropType} at ({_x}, {_y})");
        }
    }
}