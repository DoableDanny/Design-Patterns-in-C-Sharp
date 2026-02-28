using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Flyweight.MyTest;

public class Crop
{
    private int _x;
    private int _y;
    private CropIcon _cropIcon;

    public Crop(int x, int y, CropIcon cropIcon)
    {
        _x = x;
        _y = y;
        _cropIcon = cropIcon;
    }

    public void Render()
    {
        // here, we would use the crop icon to draw the crop at the specified location
        Console.WriteLine($"Drawing crop at ({_x}, {_y}) with icon {_cropIcon.GetCropType()}");
    }

}