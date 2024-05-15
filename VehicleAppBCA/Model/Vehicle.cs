
using Newtonsoft.Json;

namespace VehicleAppBCA.Model
{
    public class Vehicle
    {
        public int id { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public string engineSize { get; set; }
        public string fuel { get; set; }
        public int year { get; set; }
        public int mileage { get; set; }
        public string auctionDateTime { get; set; }
        public int startingBid { get; set; }
        public bool favourite { get; set; }
        public VehicleDetails details { get; set; }
    }
}