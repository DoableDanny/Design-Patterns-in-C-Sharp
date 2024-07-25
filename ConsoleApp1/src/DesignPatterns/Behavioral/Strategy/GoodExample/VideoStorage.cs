using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Strategy.GoodExample
{
    // Context
    public class VideoStorage
    {
        // Store references to the strategies, coding to interfaces for polymorphism/flexibility
        private ICompressor _compressor;
        private IOverlay _overlay;

        // It's common to pass the strategies via constructor
        public VideoStorage(ICompressor compressor, IOverlay overlay)
        {
            _compressor = compressor;
            _overlay = overlay;
        }

        // Provide setters so strategies can be changed at runtime
        public void SetCompressor(ICompressor compressor)
        {
            _compressor = compressor;
        }

        public void SetOverlay(IOverlay overlay)
        {
            _overlay = overlay;
        }

        public void Store(string fileName)
        {
            // Work is now delegated to the concrete compressor and overlay objects. VideoStorage now has no knowledge of the implementation details of each compression and overlay algorithm.
            _compressor.Compress();
            _overlay.Apply();

            System.Console.WriteLine("Storing video to " + fileName);
        }
    }
}