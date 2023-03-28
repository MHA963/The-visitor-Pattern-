using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany
{
    public class TypeVisitor : IVisitor
    {
        public void VisitCarInsurance(CarInsurance insurance)
        {
            Console.WriteLine($"Car Insurance: {insurance.GetCost()}");
        }

        public void VisitMotorBikeInsurance(MotorBikeInsurance insurance)
        {
            Console.WriteLine($"Motor Bike Insurance: {insurance.GetCost()}");
        }

        public void VisitBikeInsurance(BikeInsurance insurance)
        {
            Console.WriteLine($"Bike Insurance: {insurance.GetCost()}");
        }

        public void VisitTruckInsurance(TruckInsurance insurance)
        {
            Console.WriteLine($"Truck Insurance: {insurance.GetCost()}");
        }
    }
}
