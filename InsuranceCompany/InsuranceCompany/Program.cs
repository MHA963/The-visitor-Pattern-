// See https://aka.ms/new-console-template for more information


using System.Runtime.InteropServices;
using InsuranceCompany;

class Program
{
    static void Main(string[] args)
    {
        var carInsurance = new CarInsurance();
        var motorBikeInsurance = new MotorBikeInsurance();
        var bikeInsurance = new BikeInsurance();
        var truckInsurance = new TruckInsurance();
        var typeVisitor = new TypeVisitor();
        var customerCommunicationVisitor = new CustomerCommunicationVisitor();
        carInsurance.Accept(typeVisitor);
        motorBikeInsurance.Accept(typeVisitor);
        bikeInsurance.Accept(typeVisitor);
        truckInsurance.Accept(typeVisitor);

        Console.WriteLine("----------------------------------");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("----------------------------------");

        motorBikeInsurance.Accept(customerCommunicationVisitor);
        bikeInsurance.Accept(customerCommunicationVisitor);
        truckInsurance.Accept(customerCommunicationVisitor);
        carInsurance.Accept(customerCommunicationVisitor);

    }
}