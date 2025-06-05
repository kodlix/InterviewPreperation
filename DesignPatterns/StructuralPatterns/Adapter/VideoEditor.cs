namespace DesignPatterns.StructuralPatterns.Adapter
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