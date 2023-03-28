using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany
{
    public class BikeInsurance : IInsurance
    {
        public string? RegistrationNumber { get; set; }
        public string? PostCode { get; set; }
        public string? Maker { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }
        public int Value { get; set; }
        public int Mileage { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitBikeInsurance(this);
        }
    }
}
