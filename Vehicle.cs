using System;

namespace VehicleCatalogue2
{
    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public int HorsePower { get; set; }
        public void PrintData()
        {
            string type = char.ToUpper(Type[0]) + Type.Substring(1);

            Console.WriteLine($"Type: {type}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Color: {Colour}");
            Console.WriteLine($"Horsepower: {HorsePower}");
        }
    }
}
