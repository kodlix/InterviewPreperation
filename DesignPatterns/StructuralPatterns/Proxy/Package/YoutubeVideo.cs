namespace DesignPatterns.StructuralPatterns.Proxy.Package
{
    public class YouTubeVideo : IVideo
    {
        private string _videoId;


        public YouTubeVideo(string videoId)
        {
            _videoId = videoId;
            Download();
        }


        private void Download()
        {
            System.Console.WriteLine("Downloading video with id " + _videoId + " from YouTube API");
        }


        public void Render()
        {
            System.Console.WriteLine("Rendering video " + _videoId);
        }


        public string GetVideoId()
        {
            return _videoId;
        }
    }
}