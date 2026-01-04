// Question 4: Abstraction – Vehicle Rental System
// Design an abstract Vehicle class for Car, Bike, and Truck with different rental price calculations.

namespace Abstraction
{
    public abstract class VehicleRentalSystem
    {
        public double Hours{get; set;}
        public VehicleRentalSystem(){}
        public VehicleRentalSystem(double Hours)
        {
            this.Hours = Hours;
        }
        public abstract void Calculation();
    }
    public class Car : VehicleRentalSystem
    {
        public Car(){}
        public Car(double Hours) : base(Hours){}
        public override void Calculation()
        {
            double RatePrice = 2500;
            
            double Rent = RatePrice/24;
            double FinalRent = Rent * Hours;
            Console.WriteLine($"Your Car Rent is {FinalRent}");
        }
    }
    public class Bike : VehicleRentalSystem
    {
        public Bike(){}
        public Bike(double Hours) : base(Hours){}
        public override void Calculation()
        {
            double RatePrice = 1400;
            
            double Rent = RatePrice/24;
            double FinalRent = Rent * Hours;
            Console.WriteLine($"Your Bike Rent is {FinalRent}");
        }
    }
    public class Truck : VehicleRentalSystem
    {
        public Truck(){}
        public Truck(double Hours) : base(Hours){}
        public override void Calculation()
        {
            double RatePrice = 5000;
            
            double Rent = RatePrice/24;
            double FinalRent = Rent * Hours;
            Console.WriteLine($"Your Truck Rent is {FinalRent}");
        }
    }
}