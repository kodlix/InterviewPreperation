using System.Collections.Generic;

namespace DesignPatterns.StructuralPatterns.FlightWeight
{
    public class CropIconFactory
    {
        //cache
        private Dictionary<CropType, CropIcon> _icons = new Dictionary<CropType, CropIcon>();

        public CropIcon GetCropIcon(CropType cropType)
        {
            if (!_icons.ContainsKey(cropType))
            {
                var icon = new CropIcon(cropType, null);
                _icons.Add(cropType, icon);
            }

            return _icons[cropType];
        }
    }
}