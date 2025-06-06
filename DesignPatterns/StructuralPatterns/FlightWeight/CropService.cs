using System.Collections.Generic;

namespace DesignPatterns.StructuralPatterns.FlightWeight
{
    public class CropService
    {

        private CropIconFactory _cropIconFactory;

        public CropService(CropIconFactory cropIconFactory)
        {
            _cropIconFactory = cropIconFactory;
        }
        public List<Crop> GetCrops()
        {
            return new List<Crop>
            {
                new Crop(1, 1, _cropIconFactory.GetCropIcon(CropType.Carrot)),
                new Crop(2, 2, _cropIconFactory.GetCropIcon(CropType.Carrot)),
                new Crop(3, 3, _cropIconFactory.GetCropIcon(CropType.Carrot)),
            }; 
        }
    }
}