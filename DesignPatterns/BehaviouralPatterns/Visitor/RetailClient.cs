namespace DesignPatterns.BehaviouralPatterns.Visitor
{
    public class RetailClient: Client
    {
        public RetailClient(string name, string email) : base(name, email)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitRetail(this);
        }
    }
}