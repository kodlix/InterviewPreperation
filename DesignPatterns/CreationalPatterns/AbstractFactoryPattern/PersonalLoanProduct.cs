using System;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPattern
{
    public class PersonalVerification : IVerification
    {
        public void Verify() => Console.WriteLine("Performing personal loan verification...");
    }

    public class PersonalRiskAssessment : IRiskAssessment
    {
        public void Assess() => Console.WriteLine("Assessing risk for personal loan...");
    }

    public class PersonalApproval : IApproval
    {
        public void Approve() => Console.WriteLine("Approving personal loan...");
    }
}