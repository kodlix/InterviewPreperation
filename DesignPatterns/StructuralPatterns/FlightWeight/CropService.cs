using System.Collections.Generic;

namespace DesignPatterns.StructuralPatterns.FlightWeight
{
    public class CropService
    {
        public List<Crop> GetCrops()
        {
            return new List<Crop>
            {
                new Crop(1, 1, CropType.Potato, null),
                new Crop(2, 2, CropType.Carrot, null),
                new Crop(3, 3, CropType.Wheat,null),
            }; 
        }
    }
}