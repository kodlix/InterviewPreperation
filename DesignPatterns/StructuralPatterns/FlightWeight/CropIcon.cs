namespace DesignPatterns.StructuralPatterns.FlightWeight
{
    public class CropIcon
    {
        private readonly CropType _cropType;

        private readonly byte[] _icon;

        public CropIcon(CropType cropType, byte[] icon)
        {
            _cropType = _cropType;
            _icon = icon;
        }

        public CropType GetCropType()
        {
            return _cropType;
        }
    }
}