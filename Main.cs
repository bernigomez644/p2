namespace Practice2
{
    internal class Program
    {

        static void Main()

        {
            City Madrid = new City("Madrid");
            Console.WriteLine(Madrid.WriteMessage("Created"));
;
            

            PoliceStation estacion_central = new PoliceStation("Estación Central");
            Madrid.SetStation(estacion_central);
            Console.WriteLine(estacion_central.WriteMessage("Created"));
           

            Taxi taxi1 = new Taxi("0001 AAA");
            Taxi taxi2 = new Taxi("0002 BBB");
            Console.WriteLine(taxi1.WriteMessage("Created"));
            Console.WriteLine(taxi2.WriteMessage("Created"));
            PoliceCar policeCar1 = new PoliceCar("0001 CNP");
            PoliceCar policeCar2 = new PoliceCar("0002 CNP");
            Console.WriteLine(policeCar1.WriteMessage("Created"));
            Console.WriteLine(policeCar2.WriteMessage("Created"));
    

            estacion_central.registerPoliceCar(policeCar1);
            estacion_central.registerPoliceCar(policeCar2);

            Madrid.RegisterTaxiLicense(taxi1);
            Madrid.RegisterTaxiLicense(taxi2);

            Madrid.ShowRegisteredTaxis();
      

            Madrid.RemoveTaxiLicense("0001 AAA");
            Madrid.RemoveTaxiLicense("0001 AAA");


            policeCar1.StartPatrolling();
            policeCar2.StartPatrolling();
            policeCar1.UseRadar(taxi1);
            policeCar1.UseRadar(taxi2);
            policeCar2.UseRadar(taxi2);

            taxi2.StartRide();
            policeCar2.UseRadar(taxi2);
            policeCar1.PrintRadarHistory();
            policeCar2.PrintRadarHistory();


        }
    }
}

    

