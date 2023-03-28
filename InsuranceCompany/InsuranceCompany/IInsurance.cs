using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany
{
    public interface IInsurance
    {
        void Accept(IVisitor visitor);
    }

    public interface IVisitor
    {
        void VisitCarInsurance(CarInsurance insurance);
        void VisitMotorBikeInsurance(MotorBikeInsurance insurance);

        void VisitBikeInsurance(BikeInsurance insurance);

        void VisitTruckInsurance(TruckInsurance insurance);
    }
}
