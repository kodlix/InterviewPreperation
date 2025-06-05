using System.Collections.Generic;
using DesignPatterns.StructuralPatterns.Adapter;
using DesignPatterns.StructuralPatterns.Proxy.Package;

namespace DesignPatterns.StructuralPatterns.Proxy
{
    public class VideoList
    {
        private Dictionary<string, IVideo> _videoList = new Dictionary<string, IVideo>();


        public void Add(IVideo video)
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