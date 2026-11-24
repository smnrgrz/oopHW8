using System;
namespace Transport
{
    enum FuelType
    {
        Petrol,
        Diesel,
        Electric
    }
    class Vehicle
    {
        public static int Count = 0;
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public FuelType Fuel { get; set; }

        public Vehicle(string brand, string model, int year, FuelType fuel)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Fuel = fuel;
            Count++;
        }
        public virtual void StartEngine()
        {
            Console.WriteLine("Starting the engine of the vehicle.");
        }

        public string Info()
        {
            return $"Brand: {Brand}, Model: {Model}, Year: {Year}, Fuel: {Fuel}";
        }
    }
    class Car : Vehicle
    {
        public Car(string brand, string model, int year, FuelType fuel)
            : base(brand, model, year, fuel)
        {
        }

        public override void StartEngine()
        {
            Console.WriteLine("Starting the car engine.");
        }
    }

    class Truck : Vehicle
    {
        public Truck(string brand, string model, int year, FuelType fuel)
            : base(brand, model, year, fuel)
        {
        }

        public override void StartEngine()
        {
            Console.WriteLine("Starting the truck engine.");
        }
    }

    class Motorcycle : Vehicle
    {
        public Motorcycle(string brand, string model, int year, FuelType fuel)
            : base(brand, model, year, fuel)
        {
        }

        public override void StartEngine()
        {
            Console.WriteLine("Starting the motorcycle engine.");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] fleet =
            {
                new Car("TOGG", "T10X", 2023, FuelType.Electric),
                new Truck("Ford", "F-MAX", 2022, FuelType.Diesel),
                new Motorcycle("Yamaha", "MT-07", 2021, FuelType.Petrol)
            };
            foreach (Vehicle v in fleet)
            {
                Console.WriteLine($"Brand: {v.Brand}, Model: {v.Model}, Year: {v.Year}, Fuel: {v.Fuel}");
                v.StartEngine();
            }
            Console.WriteLine($"Total:{Vehicle.Count}");
        }
    }
}
