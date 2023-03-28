﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany
{
    public class TruckInsurance : IInsurance
    {
        public string? RegistrationNumber { get; set; }
        public string? PostCode { get; set; }
        public string? Maker { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }
        public int Value { get; set; }
        public int Mileage { get; set; }
        public int EngineSize { get; set; }
        public int NoOfPreviousOwners { get; set; }
        public bool IsModified { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitTruckInsurance(this);
        }

        //public void Truck(string registrationumber, string postcode, string maker,
        //    string model, int year, int value, int mileage, int enginesize, int noofpreviousowners,
        //    bool ismodified)
        //{
        //    RegistrationNumber = registrationumber;
        //    PostCode = postcode;
        //    Maker = maker;
        //    Model = model;
        //    Year = year;
        //    Value = value;
        //    Mileage = mileage;
        //    EngineSize = enginesize;
        //    NoOfPreviousOwners = noofpreviousowners;
        //    IsModified = ismodified;

        //}

        //void print()
        //{
        //    Console.WriteLine("Truck Insurance");
        //    Console.WriteLine("Registration Number: " + RegistrationNumber);
        //    Console.WriteLine("Post Code: " + PostCode);
        //    Console.WriteLine("Maker: " + Maker);
        //    Console.WriteLine("Model: " + Model);
        //    Console.WriteLine("Year: " + Year);
        //    Console.WriteLine("Value: " + Value);
        //    Console.WriteLine("Mileage: " + Mileage);
        //    Console.WriteLine("Engine Size: " + EngineSize);
        //    Console.WriteLine("No Of Previous Owners: " + NoOfPreviousOwners);
        //    Console.WriteLine("Is Modified: " + IsModified);
        //}

        public int GetCost()
        {
            return 69420;
        }

        public string GetCommunication()
        {
            return "Truck insurance wants Email and Fax communication";
        }
    }
}
