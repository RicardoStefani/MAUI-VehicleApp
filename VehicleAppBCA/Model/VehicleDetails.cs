using System;
namespace VehicleAppBCA.Model
{
	public class VehicleDetails
	{
        public VehicleSpecification specification { get; set; }
        public VehicleOwnership ownership { get; set; }
        public List<string> equipment { get; set; }
    }
}

