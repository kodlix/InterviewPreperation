namespace DesignPatterns.BehaviouralPatterns.Visitor
{
    public interface IVisitor
    {
        void VisitRetail(RetailClient retailClient);
        void VisitLaw(LawClient lawClient);
        void VisitRestaurant(RestaurantClient restaurantClient);
    }
}