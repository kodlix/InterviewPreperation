using System;
using System.Reflection;

namespace DesignPatterns.StructuralPatterns.Decorator
{
    public class ValidationDecorator : DataDecorator
    {
        public ValidationDecorator(IData data) : base(data)
        {
        }

        public override void Save(string data)
        {
            System.Console.WriteLine("Validation input data for compliance");
            var validated = Validate(data);
            base._data.Save(validated);
        }

        // This can now be private, encapsulating this code
        private string Validate(string data)
        {
            if (data is null)
            {
                throw new ArgumentNullException("Input data is missing");
            }

            return data; // pretend to encrypt data
        }
    }
}