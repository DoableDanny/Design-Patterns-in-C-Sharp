using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Flyweight.MyTest
{
    public class CropIcon
    {
        private readonly CropType _cropType;
        private readonly byte[] _icon;

        public CropIcon(CropType cropType, byte[] icon)
        {
            _cropType = cropType;
            _icon = icon;
        }

        public CropType GetCropType()
        {
            return _cropType;
        }
    }
}
