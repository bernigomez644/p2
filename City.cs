using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice2
{
    internal class City: IMessageWritter

    {
        public string CityName { get; private set; }
        public List<PoliceStation> PoliceStations { get;}
        public List<Taxi> RegisteredTaxis{get;}

        public City(string name)

        { 
            CityName = name;
            PoliceStations = new List<PoliceStation>();
            RegisteredTaxis = new List<Taxi>();

        }
        public void SetStation(PoliceStation policeStation)
        {
            PoliceStations.Add(policeStation);
            policeStation.City = this;

        }
        public void RegisterTaxiLicense(Taxi taxi)
        {
            if (RegisteredTaxis.Contains(taxi))
            {
                Console.WriteLine("This taxi already has a licence");
            }
            else 
            {
                RegisteredTaxis.Add(taxi);
                taxi.City = this;
                Console.WriteLine(WriteMessage($"Registered taxi with plate {taxi.GetPlate()}"));
            }
        }

        public void RemoveTaxiLicense(Taxi taxi)
        {
            string plate = taxi.GetPlate();
            Taxi? taxiToRemove = RegisteredTaxis.Find(taxi => taxi.GetPlate() == plate);

            if (taxiToRemove != null)
            {
                RegisteredTaxis.Remove(taxiToRemove);
                Console.WriteLine(WriteMessage($"Taxi license with plate {plate} has been removed."));
                taxiToRemove.City = null;

            }
            else
            {
                Console.WriteLine(WriteMessage($"Taxi with plate {plate} not found in the registered taxis license of {CityName}."));
            }
        }

        public override string ToString()
        {
            return $"City {CityName}:";
        }

        public string WriteMessage(string message)
        {
            return $"{this} {message}";
        }

        public void ShowRegisteredTaxis()
        {
            List<string> plates = new List<string>();
            foreach (Taxi taxi in RegisteredTaxis)
            {
                plates.Add(taxi.GetPlate());
            }
            string platesAsString = string.Join(", ", plates);

            Console.WriteLine(WriteMessage($"Taxis registered: {platesAsString}"));
        }


    }
}
