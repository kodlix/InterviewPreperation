namespace DesignPatterns.CreationalPatterns.AbstractFactoryPattern
{
    public interface IVerification
    {
        void Verify();
    }

    public interface IRiskAssessment
    {
        void Assess();
    }

    public interface IApproval
    {
        void Approve();
    }
    
    
    public interface ILoanProcessFactory
    {
        IVerification CreateVerification();
        IRiskAssessment CreateRiskAssessment();
        IApproval CreateApproval();
    }
}