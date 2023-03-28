﻿// See https://aka.ms/new-console-template for more information


using System.Diagnostics.Metrics;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.InteropServices;
using InsuranceCompany;

class Program
{
    static void Main(string[] args)
    {
        var carInsurance = new CarInsurance();
        //carInsurance.Car("Regi-1", "8240", "Toyota", "Supra", 1998, 20000, 30000, 8, 2, true);
        var motorBikeInsurance = new MotorBikeInsurance();
        //motorBikeInsurance.MotorBike("Regi-2","8210", "Toyota", "RealFastBike", 2020,50000,1000,12,0,false);
        var bikeInsurance = new BikeInsurance();
        //bikeInsurance.Bike("Regi-3", "8240", "Cube", "CubeMasterBiker3000", 2000, 3000, 1000);
        var truckInsurance = new TruckInsurance();
        //truckInsurance.Truck("Regi-4", "8240", "Lamborghini", "MegaPlower", 2023, 300000, 0, 24, 0, false);
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