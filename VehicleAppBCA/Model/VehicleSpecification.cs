using System;
namespace VehicleAppBCA.Model
{
	public class VehicleSpecification
	{
        public string vehicleType { get; set; }
        public string colour { get; set; }
        public string fuel { get; set; }
        public string transmission { get; set; }
        public int numberOfDoors { get; set; }
        public string co2Emissions { get; set; }
        public int noxEmissions { get; set; }
        public int numberOfKeys { get; set; }
    }
}

