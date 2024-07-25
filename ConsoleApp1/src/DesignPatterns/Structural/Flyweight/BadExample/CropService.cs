using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Flyweight.BadExample
{
    public class CropService
    {
        public List<Crop> GetCrops()
        {
            List<Crop> cropList = new List<Crop>();

            // Simulate fetching from database/api
            var carrot = new Crop(1, 4, CropType.Carrot, null); // passing null for icon for convenience
            var carrot2 = new Crop(1, 5, CropType.Carrot, null);
            var carrot3 = new Crop(1, 6, CropType.Carrot, null);

            cropList.Add(carrot);
            cropList.Add(carrot2);
            cropList.Add(carrot3);
            return cropList;
        }
    }
}