using System;

namespace DesignPatterns.BehaviouralPatterns.Visitor
{
    public class EmailVisitor: IVisitor
    {
        public void VisitRetail(RetailClient retailClient)
        {
            Console.WriteLine($"Sending retail marketing email to retail client: {retailClient.GetEmail()}");
        }

        public void VisitLaw(LawClient lawClient)
        {
            Console.WriteLine($"Sending law marketing email to retail client: {lawClient.GetEmail()}");
        }

        public void VisitRestaurant(RestaurantClient restaurantClient)
        {
            Console.WriteLine($"Sending restaurant marketing email to retail client: {restaurantClient.GetEmail()}");
        }
    }
}