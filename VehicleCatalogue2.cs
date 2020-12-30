using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleCatalogue2
{
    class VehicleCatalogue2
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            //{typeOfVehicle} {model} {color} {horsepower}
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputArray = input.Split(' ');
                string typeOfVehicle = inputArray[0];
                string model = inputArray[1];
                string colour = inputArray[2];
                int horsePower = int.Parse(inputArray[3]);

                Vehicle vehicle = new Vehicle()
                {
                    Type = typeOfVehicle,
                    Model = model,
                    Colour = colour,
                    HorsePower = horsePower
                };

                catalog.AddVehicle(vehicle);
                input = Console.ReadLine();
            }
            while (input != "Close the Catalogue")
            {
                string model = input;
                List<Vehicle> cars = catalog.Cars.FindAll(x => x.Model == model);
                List<Vehicle> trucks = catalog.Trucks.FindAll(x => x.Model == model);
                if (cars.Count > 0)
                {
                    foreach (Vehicle car in cars)
                    {
                        car.PrintData();
                    }
                }
                else if (trucks.Count > 0)
                {
                    foreach (Vehicle truck in trucks)
                    {
                        truck.PrintData();
                    }
                }
                input = Console.ReadLine();
            }
            string type = "Car";
            double averageHorsePower = catalog.AverageHorsePower(catalog.Cars);

            PrintHorsePower(type, averageHorsePower);

            type = "Truck";
            averageHorsePower = catalog.AverageHorsePower(catalog.Trucks);

            PrintHorsePower(type, averageHorsePower);
        }
        private static void PrintHorsePower(string type, double averageHorsePower)
        {
            Console.WriteLine($"{type + 's'} have average horsepower of: {averageHorsePower:f2}.");
        }
    }
}
