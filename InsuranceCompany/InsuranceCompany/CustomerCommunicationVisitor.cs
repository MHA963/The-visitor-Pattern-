using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany
{
    public class CustomerCommunicationVisitor : IVisitor
    {
        public void VisitCarInsurance(CarInsurance insurance)
        {
            Console.WriteLine($"{insurance.GetCommunication()}");
        }

        public void VisitMotorBikeInsurance(MotorBikeInsurance insurance)
        {
            Console.WriteLine($"{insurance.GetCommunication()}");
        }

        public void VisitBikeInsurance(BikeInsurance insurance)
        {
            Console.WriteLine($"{insurance.GetCommunication()}");
        }

        public void VisitTruckInsurance(TruckInsurance insurance)
        {
            Console.WriteLine($"{insurance.GetCommunication()}");
        }
    }
}
