namespace DesignPatterns.CreationalPatterns.AbstractFactoryPattern
{
    public class LoanProcessor
    {
        private readonly IVerification _verification;
        private readonly IRiskAssessment _riskAssessment;
        private readonly IApproval _approval;

        public LoanProcessor(ILoanProcessFactory factory)
        {
            _verification = factory.CreateVerification();
            _riskAssessment = factory.CreateRiskAssessment();
            _approval = factory.CreateApproval();
        }

        public void ProcessLoan()
        {
            _verification.Verify();
            _riskAssessment.Assess();
            _approval.Approve();
        }
    }
}