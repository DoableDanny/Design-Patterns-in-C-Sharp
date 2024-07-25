using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.src.DesignPatterns.Structural.Proxy.BadExample.ThirdPartyVideoLib;

namespace ConsoleApp1.src.DesignPatterns.Structural.Proxy.BadExample
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