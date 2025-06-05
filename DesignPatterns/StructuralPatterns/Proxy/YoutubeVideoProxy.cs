using DesignPatterns.StructuralPatterns.Proxy.Package;

namespace DesignPatterns.StructuralPatterns.Proxy
{
    public class YoutubeVideoProxy: IVideo
    {
        private string _videoId;
        private YouTubeVideo _youTubeVideo;

        public YoutubeVideoProxy(string videoId)
        {
            _videoId = videoId;
        }
        public void Render()
        {
            if (_youTubeVideo == null)
            {
                _youTubeVideo = new YouTubeVideo(_videoId);
            }

            _youTubeVideo.Render();
        }

        public string GetVideoId()
        {
            return _videoId;
        }
    }
}