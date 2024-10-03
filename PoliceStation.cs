using System.Collections.Generic;

namespace Practice2
{
    internal class PoliceStation
    {
        public List<PoliceCar> listOfPoliceCars = new List<PoliceCar>();
        public City City { get; set; }
        public string Name { get; private set;}
        private Alarm alarm;
        public string? ilegal_car;
        public PoliceStation(string name)
        {
            alarm = new Alarm(this);
            Name = name;
        }
        public void RegisterPoliceCar(PoliceCar policeCar)
        {
            listOfPoliceCars.Add(policeCar);
            policeCar.SetStation(this);
            Console.WriteLine(WriteMessage($"registered police car with plate {policeCar.GetPlate()}"));
        }

        public void activateAlarm()
        {
            alarm.activate_alarm(ilegal_car);

            foreach (PoliceCar policeCar in listOfPoliceCars)
            {
                policeCar.StartChasing();
            }

        }

        public override string ToString()
        {
            return $"The Police Station named {Name},located in {City.CityName}";
        }

        public string WriteMessage(string message)
        {
            return $"{this}: {message}";
        }
    }

    
}
