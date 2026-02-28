using ConsoleApp1.src.DesignPatterns.Structural.Proxy.MyTest.ThirdPartyVideoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Proxy.MyTest
{
    public class YouTubeVideoProxy : Video
    {
        private string _videoId;
        private YouTubeVideo _youTubeVideo;

        public YouTubeVideoProxy(string videoId)
        {
            _videoId = videoId;
        }
        public string GetVideoId()
        {
            return _videoId;
        }

        public void Render()
        {
            if (_youTubeVideo == null)
            {
                _youTubeVideo = new YouTubeVideo(_videoId);
            }
            _youTubeVideo.Render();
            ;
        }
    }
}
