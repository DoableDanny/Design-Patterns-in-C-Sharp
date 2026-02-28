using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Flyweight.MyTest
{
    public class CropService
    {
        private readonly CropIconFactory _cropIconFactory;
        public CropService(CropIconFactory cropIconFactory)
        {
            _cropIconFactory = cropIconFactory;
        }
        public List<Crop> GetCrops()
        {
            // In a real implementation, you would retrieve crop data from a database or other data source
            List<Crop> crops = new List<Crop> {
                new Crop(10, 20, _cropIconFactory.GetCropIcon(CropType.Wheat)),
                new Crop(30, 40, _cropIconFactory.GetCropIcon(CropType.Potato)),
                new Crop(31, 45, _cropIconFactory.GetCropIcon(CropType.Carrot)),
                new Crop(40, 47, _cropIconFactory.GetCropIcon(CropType.Potato)),
                new Crop(50, 58, _cropIconFactory.GetCropIcon(CropType.Wheat))
            };

            return crops;
        }
    }
}

