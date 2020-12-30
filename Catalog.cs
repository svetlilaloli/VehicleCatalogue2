using System.Collections.Generic;

namespace VehicleCatalogue2
{
    class Catalog
    {
        public List<Vehicle> Cars { get; set; }
        public List<Vehicle> Trucks { get; set; }
        public Catalog()
        {
            Cars = new List<Vehicle>();
            Trucks = new List<Vehicle>();
        }
        public void AddVehicle(Vehicle vehicle)
        {
            if (vehicle.Type == "car")
            {
                Cars.Add(vehicle);
            }
            else if(vehicle.Type == "truck")
            {
                Trucks.Add(vehicle);
            }
        }
        
        public double AverageHorsePower(List<Vehicle> vehicles)
        {
            double sum = 0;
            if (vehicles.Count > 0)
            {
                foreach (Vehicle vehicle in vehicles)
                {
                    sum += vehicle.HorsePower;
                }
                return sum / vehicles.Count;
            }
            else
            {
                return sum;
            }
        }
    }
}
