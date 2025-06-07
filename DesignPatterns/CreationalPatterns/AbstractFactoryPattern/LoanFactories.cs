namespace DesignPatterns.CreationalPatterns.AbstractFactoryPattern
{
    public class PersonalLoanFactory : ILoanProcessFactory
    {
        public IVerification CreateVerification() => new PersonalVerification();
        public IRiskAssessment CreateRiskAssessment() => new PersonalRiskAssessment();
        public IApproval CreateApproval() => new PersonalApproval();
    }

    public class BusinessLoanFactory : ILoanProcessFactory
    {
        public IVerification CreateVerification() => new BusinessVerification();
        public IRiskAssessment CreateRiskAssessment() => new BusinessRiskAssessment();
        public IApproval CreateApproval() => new BusinessApproval();
    }
}