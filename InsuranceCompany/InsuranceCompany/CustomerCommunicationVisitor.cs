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
            Console.WriteLine($"Email is sent as the element class is: {insurance.GetType()}");
        }

        public void VisitMotorBikeInsurance(MotorBikeInsurance insurance)
        {
            Console.WriteLine($"SMS is sent as the element class is:  {insurance.GetType()}");
        }

        public void VisitBikeInsurance(BikeInsurance insurance)
        {
            Console.WriteLine($"Fax is sent as the element class is: {insurance.GetType()}");
        }

        public void VisitTruckInsurance(TruckInsurance insurance)
        {
            Console.WriteLine($"Phone call is made as the element class is: {insurance.GetType()}");
        }
    }
}
