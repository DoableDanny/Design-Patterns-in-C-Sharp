using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Adapter.MyTest
{
    public class VideoEditor
    {
        private Video _video;
       
        public VideoEditor(Video video)
        {
            _video = video;
        }

        public void ApplyColor(IColor color)
        {
            color.Apply(_video);
        }
    }
}
