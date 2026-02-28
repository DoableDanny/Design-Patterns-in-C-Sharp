using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Flyweight.MyTest
{
    public class CropIconFactory
    {
        private Dictionary<CropType, CropIcon> _icons = new Dictionary<CropType, CropIcon>(); //Cache

        public CropIcon GetCropIcon(CropType cropType)
        {
            if (!_icons.ContainsKey(cropType))
            {
                var icon = new CropIcon( cropType, null ); // In a real implementation, you would load the icon data from a file or database
                _icons.Add(cropType, icon);
            }
            return _icons[cropType];
        }
    }
}
