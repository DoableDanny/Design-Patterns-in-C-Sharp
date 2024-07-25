using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Strategy.BadExample
{
    public class VideoStorage
    {
        private Compressors _compressor;
        private Overlays _overlay;

        public VideoStorage(Compressors compressor, Overlays overlay = Overlays.NONE)
        {
            _compressor = compressor;
            _overlay = overlay;
        }

        public void SetCompressor(Compressors compressor)
        {
            _compressor = compressor;
        }

        public void SetOverlay(Overlays overlay)
        {
            _overlay = overlay;
        }

        public void Store(string fileName)
        {
            if (_compressor == Compressors.MOV)
            {
                System.Console.WriteLine("Compressing using MOV");
            }
            else if (_compressor == Compressors.MP4)
            {
                System.Console.WriteLine("Compressing using MP4");
            }
            else if (_compressor == Compressors.WEBM)
            {
                System.Console.WriteLine("Compressing using WEBM");
            }

            if (_overlay == Overlays.BLACK_AND_WHITE)
            {
                System.Console.WriteLine("Applying black and white overlay");
            }
            else if (_overlay == Overlays.BLUR)
            {
                System.Console.WriteLine("Applying blur overlay");
            }
            else if (_overlay == Overlays.NONE)
            {
                System.Console.WriteLine("Not applying an overlay");
            }

            System.Console.WriteLine("Storing video to " + fileName);
        }
    }
}