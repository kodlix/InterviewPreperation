using System;

namespace DesignPatterns.BehaviouralPatterns.Strategy
{
    public class VideoStorage
    {
        private ICompressor _compressor;
        private IOverlay _overlay;

        public VideoStorage(ICompressor compressor, IOverlay overlay)
        {
            _compressor = compressor;
            _overlay = overlay;
        }
        
        public void SetCompressor(ICompressor compressor)
        {
            _compressor = compressor;
        }
        
        public void SetOverlay(IOverlay overlay)
        {
            _overlay = overlay;
        }
        
        public void Store(string videoFile)
        {
            _compressor.Compress();
            _overlay.Apply();
            Console.WriteLine("Storing video to " + videoFile + "." + _compressor);
        }
    }
}