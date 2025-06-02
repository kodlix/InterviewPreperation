using System;

namespace DesignPatterns.BehaviouralPatterns.Visitor
{
    public class PdfExportVisitor: IVisitor
    {
        public void VisitRetail(RetailClient retailClient)
        {
            Console.WriteLine($"Exporting retail marketing info as PDF");
        }

        public void VisitLaw(LawClient lawClient)
        {
            Console.WriteLine($"Exporting law marketing info as PDF");
        }

        public void VisitRestaurant(RestaurantClient restaurantClient)
        {
            Console.WriteLine($"Exporting restaurant marketing info as PDF");
        }
    }
}