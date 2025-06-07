using System;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPattern
{
    public class BusinessVerification : IVerification
    {
        public void Verify() => Console.WriteLine("Performing business loan verification...");
    }

    public class BusinessRiskAssessment : IRiskAssessment
    {
        public void Assess() => Console.WriteLine("Assessing risk for business loan...");
    }

    public class BusinessApproval : IApproval
    {
        public void Approve() => Console.WriteLine("Approving business loan...");
    }

}