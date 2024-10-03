namespace Practice2
{
    class PoliceCar : VehicleWithPlate
    {
        private const string typeOfVehicle = "Police Car";
        public bool IsPatrolling { get; private set; }
        private SpeedRadar? speedRadar;
        private PoliceStation policeStation;
        public string? ilegal_car {get; set;}
        private bool isChasing;


        public PoliceCar(string plate) : base(typeOfVehicle, plate)
        {
            IsPatrolling = false;
            //speedRadar = new SpeedRadar(); // lo dejo comentado para que no siempre contenga un objeto radar 
        }

        public void SetRadar(SpeedRadar speedRadar)
        {
            this.speedRadar = speedRadar;
            Console.WriteLine(WriteMessage("has radar"));
        }

        public void UseRadar(Vehicle vehicle)
        {
            if (speedRadar == null && IsPatrolling)
            {
                Console.WriteLine(WriteMessage($"Is patrolling but has no radar"));
            }
            else if (IsPatrolling && speedRadar != null)
            {
                speedRadar.TriggerRadar(vehicle);
                (string meassurement,bool ilegal_velocity) = speedRadar.GetLastReading();
                Console.WriteLine(WriteMessage($"Triggered radar. Result: {meassurement}"));

                if (ilegal_velocity)
                {
                    policeStation.ilegal_car = vehicle.GetPlate();
                    policeStation.activateAlarm();
               
                }
            

            }
            else
            {
                Console.WriteLine(WriteMessage($"Is not patrolling."));
            }
        }

        public void StartPatrolling()
        {
            if (!IsPatrolling)
            {
                IsPatrolling = true;
                Console.WriteLine(WriteMessage("started patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is already patrolling."));
            }
        }

        public void EndPatrolling()
        {
            if (IsPatrolling)
            {
                IsPatrolling = false;
                Console.WriteLine(WriteMessage("stopped patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("was not patrolling."));
            }
        }

        public void PrintRadarHistory()
        {
            if (speedRadar == null)
            {
                Console.WriteLine(WriteMessage("has no radar"));
            }
            else
            {
                Console.WriteLine(WriteMessage("Report radar speed history:"));
                foreach (float speed in speedRadar.SpeedHistory)
                {
                    Console.WriteLine(speed);
                }
            }
        }

        public void StartChasing()
        {
            if (isChasing)
            {
                Console.WriteLine(WriteMessage("Already on pursuit"));
            }
            else
            {
                isChasing = true;
                Console.WriteLine(WriteMessage($"chasing car with plate {ilegal_car}"));
            }

        }

        public void SetStation(PoliceStation policeStation)
        {
            this.policeStation = policeStation;
        }


    }
}