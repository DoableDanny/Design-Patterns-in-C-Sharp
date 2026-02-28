using ConsoleApp1.src.DesignPatterns.Structural.Proxy.MyTest.ThirdPartyVideoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Proxy.MyTest
{
    public class VideoList
    {
        private Dictionary<string, Video> _videoList = new Dictionary<string, Video>();


        public void Add(Video video)
        {
            _videoList.Add(video.GetVideoId(), video);
        }


        public void Watch(string videoId)
        {
            var video = _videoList[videoId];
            video.Render();
        }
    }
}
