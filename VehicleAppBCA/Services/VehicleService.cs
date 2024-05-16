using System;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using VehicleAppBCA.Model;

namespace VehicleAppBCA.Services
{
	public class VehicleService
	{
        private static List<Vehicle> vehicles = new List<Vehicle>();
        //private ObservableCollection<Vehicle> vehicles = new ObservableCollection<Vehicle>();

        protected VehicleService()
        {
            if (vehicles.Count() <= 0)
              vehicles = JsonConvert.DeserializeObject<List<Vehicle>>(teste);
        }

        public static VehicleService Build()
        {
          return new VehicleService();
        }

        public List<Vehicle> SaveVehicle(Vehicle vehicle)
        {
          if (vehicle.id == -1)
          {
            vehicle.id = vehicles.Count();
            vehicles.Add(vehicle);
          }
          else
          {
            RemoveVehicle(vehicle.id);
            vehicles.Add(vehicle);
          }
          
          return vehicles;
        }
        
        public List<Vehicle> RemoveVehicle(int id)
        {
            var vehicleRemove  = vehicles.FirstOrDefault(x => x.id == id); //vehicles.FindIndex(x => x.id == id);
            
            vehicles.Remove(vehicleRemove);

            return vehicles;
        }

        public Vehicle? GetVehicle(int id)
        {
            return vehicles.FirstOrDefault(x => x.id == id);
        }

        public List<Vehicle> GetVehicles()
        {
            return vehicles;
        }


        string teste = @"[
  {
    ""id"": 0,
    ""make"": ""Toyota"",
    ""model"": ""C-HR"",
    ""engineSize"": ""1.8L"",
    ""fuel"": ""diesel"",
    ""year"": 2022,
    ""mileage"": 743,
    ""auctionDateTime"": ""2024/04/15 09:00:00"",
    ""startingBid"": 17000,
    ""favourite"": true,
    ""details"": {
      ""specification"": {
        ""vehicleType"": ""Car"",
        ""colour"": ""RED"",
        ""fuel"": ""petrol"",
        ""transmission"": ""Manual"",
        ""numberOfDoors"": 3,
        ""co2Emissions"": ""139 g/km"",
        ""noxEmissions"": 230,
        ""numberOfKeys"": 2
      },
      ""ownership"": {
        ""logBook"": ""Present"",
        ""numberOfOwners"": 8,
        ""dateOfRegistration"": ""2015/03/31 09:00:00""
      },
      ""equipment"": [
        ""Air Conditioning"",
        ""Tyre Inflation Kit"",
        ""Photocopy of V5 Present"",
        ""Navigation HDD"",
        ""17 Alloy Wheels"",
        ""Engine Mods/Upgrades"",
        ""Modifd/Added Body Parts""
      ]
    }
  },
  {
    ""id"": 1,
    ""make"": ""Ford"",
    ""model"": ""Fiesta"",
    ""engineSize"": ""1.6L"",
    ""fuel"": ""petrol"",
    ""year"": 2022,
    ""mileage"": 9084,
    ""auctionDateTime"": ""2024/04/15 09:00:00"",
    ""startingBid"": 15000,
    ""favourite"": false,
    ""details"": {
      ""specification"": {
        ""vehicleType"": ""Car"",
        ""colour"": ""RED"",
        ""fuel"": ""petrol"",
        ""transmission"": ""Manual"",
        ""numberOfDoors"": 3,
        ""co2Emissions"": ""139 g/km"",
        ""noxEmissions"": 230,
        ""numberOfKeys"": 2
      },
      ""ownership"": {
        ""logBook"": ""Present"",
        ""numberOfOwners"": 8,
        ""dateOfRegistration"": ""2015/03/31 09:00:00""
      },
      ""equipment"": [
        ""Air Conditioning"",
        ""Tyre Inflation Kit"",
        ""Photocopy of V5 Present"",
        ""Navigation HDD"",
        ""17 Alloy Wheels"",
        ""Engine Mods/Upgrades"",
        ""Modifd/Added Body Parts""
      ]
    }
  },
  {
    ""id"": 2,
    ""make"": ""Toyota"",
    ""model"": ""Corolla"",
    ""engineSize"": ""1.6L"",
    ""fuel"": ""diesel"",
    ""year"": 2020,
    ""mileage"": 17293,
    ""auctionDateTime"": ""2024/04/15 09:00:00"",
    ""startingBid"": 15000,
    ""favourite"": false,
    ""details"": {
      ""specification"": {
        ""vehicleType"": ""Car"",
        ""colour"": ""RED"",
        ""fuel"": ""petrol"",
        ""transmission"": ""Manual"",
        ""numberOfDoors"": 3,
        ""co2Emissions"": ""139 g/km"",
        ""noxEmissions"": 230,
        ""numberOfKeys"": 2
      },
      ""ownership"": {
        ""logBook"": ""Present"",
        ""numberOfOwners"": 8,
        ""dateOfRegistration"": ""2015/03/31 09:00:00""
      },
      ""equipment"": [
        ""Air Conditioning"",
        ""Tyre Inflation Kit"",
        ""Photocopy of V5 Present"",
        ""Navigation HDD"",
        ""17 Alloy Wheels"",
        ""Engine Mods/Upgrades"",
        ""Modifd/Added Body Parts""
      ]
    }
  },
  {
    ""id"": 3,
    ""make"": ""Volkswagen"",
    ""model"": ""Polo"",
    ""engineSize"": ""1.6L"",
    ""fuel"": ""petrol"",
    ""year"": 2019,
    ""mileage"": 5025,
    ""auctionDateTime"": ""2024/04/15 09:00:00"",
    ""startingBid"": 17000,
    ""favourite"": true,
    ""details"": {
      ""specification"": {
        ""vehicleType"": ""Car"",
        ""colour"": ""RED"",
        ""fuel"": ""petrol"",
        ""transmission"": ""Manual"",
        ""numberOfDoors"": 3,
        ""co2Emissions"": ""139 g/km"",
        ""noxEmissions"": 230,
        ""numberOfKeys"": 2
      },
      ""ownership"": {
        ""logBook"": ""Present"",
        ""numberOfOwners"": 8,
        ""dateOfRegistration"": ""2015/03/31 09:00:00""
      },
      ""equipment"": [
        ""Air Conditioning"",
        ""Tyre Inflation Kit"",
        ""Photocopy of V5 Present"",
        ""Navigation HDD"",
        ""17 Alloy Wheels"",
        ""Engine Mods/Upgrades"",
        ""Modifd/Added Body Parts""
      ]
    }
  },
  {
    ""id"": 4,
    ""make"": ""Volkswagen"",
    ""model"": ""Passat"",
    ""engineSize"": ""1.6L"",
    ""fuel"": ""petrol"",
    ""year"": 2021,
    ""mileage"": 5384,
    ""auctionDateTime"": ""2024/04/15 09:00:00"",
    ""startingBid"": 20000,
    ""favourite"": false,
    ""details"": {
      ""specification"": {
        ""vehicleType"": ""Car"",
        ""colour"": ""RED"",
        ""fuel"": ""petrol"",
        ""transmission"": ""Manual"",
        ""numberOfDoors"": 3,
        ""co2Emissions"": ""139 g/km"",
        ""noxEmissions"": 230,
        ""numberOfKeys"": 2
      },
      ""ownership"": {
        ""logBook"": ""Present"",
        ""numberOfOwners"": 8,
        ""dateOfRegistration"": ""2015/03/31 09:00:00""
      },
      ""equipment"": [
        ""Air Conditioning"",
        ""Tyre Inflation Kit"",
        ""Photocopy of V5 Present"",
        ""Navigation HDD"",
        ""17 Alloy Wheels"",
        ""Engine Mods/Upgrades"",
        ""Modifd/Added Body Parts""
      ]
    }
  }
]";
    }
} 

