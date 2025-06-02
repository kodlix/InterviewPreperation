namespace DesignPatterns.BehaviouralPatterns.Visitor
{
    public class LawClient: Client
    {
        public LawClient(string name, string email) : base(name, email)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitLaw(this);
        }
    }
}