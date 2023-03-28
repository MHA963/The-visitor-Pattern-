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

        //public void Bike(string registrationumber, string postcode, string maker,
        //    string model, int year, int value, int mileage)
        //{
        //    RegistrationNumber = registrationumber;
        //    PostCode = postcode;
        //    Maker = maker;
        //    Model = model;
        //    Year = year;
        //    Value = value;
        //    Mileage = mileage;
        //}

        //void print()
        //{
        //    Console.WriteLine("Bike Insurance");
        //    Console.WriteLine("Registration Number: " + RegistrationNumber);
        //    Console.WriteLine("Post Code: " + PostCode);
        //    Console.WriteLine("Maker: " + Maker);
        //    Console.WriteLine("Model: " + Model);
        //    Console.WriteLine("Year: " + Year);
        //    Console.WriteLine("Value: " + Value);
        //    Console.WriteLine("Mileage: " + Mileage);
        //}

        public int GetCost()
        {
            return 420;
        }

        public string GetCommunication()
        {
            return "Bike Insurance, Wants SMS communication";
        }
    }
}
