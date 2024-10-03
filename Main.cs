using Practice2;

namespace Practice2
{
    internal class Program
    {
        static void Main()
        {
            City madrid = new City("Madrid");
            Console.WriteLine(madrid.WriteMessage("Created"));
            PoliceStation centralStation = new PoliceStation("Central Station");
            madrid.SetStation(centralStation);
            Console.WriteLine(centralStation.WriteMessage("Created"));

            
            Console.WriteLine(" ");

            Taxi taxi1 = new Taxi("0001 AAA");
            Console.WriteLine(taxi1.WriteMessage("Created"));
            madrid.RegisterTaxiLicense(taxi1);
            madrid.RegisterTaxiLicense(taxi1);
            Console.WriteLine(" ");

            Taxi taxi2 = new Taxi("0002 BBB");
            Console.WriteLine(taxi2.WriteMessage("Created"));
            madrid.RegisterTaxiLicense(taxi2);
            Console.WriteLine(" ");

            Taxi taxi3 = new Taxi("0003 CCC");
            Console.WriteLine(taxi3.WriteMessage("Created"));
            madrid.RegisterTaxiLicense(taxi3);
            Console.WriteLine(" ");

            Console.WriteLine("Police 1 and 3 will have radar, but 2 wont");
            Console.WriteLine(" ");

            PoliceCar policeCar1 = new PoliceCar("0001 CNP");
            Console.WriteLine(policeCar1.WriteMessage("Created"));
            centralStation.RegisterPoliceCar(policeCar1);
            SpeedRadar radar1 = new SpeedRadar();
            policeCar1.SetRadar(radar1);
            policeCar1.StartPatrolling();
            Console.WriteLine(" ");

            PoliceCar policeCar2 = new PoliceCar("0002 CNP");
            Console.WriteLine(policeCar2.WriteMessage("Created"));
            centralStation.RegisterPoliceCar(policeCar2);
            SpeedRadar radar2 = new SpeedRadar();
            policeCar2.StartPatrolling();
            Console.WriteLine(" ");

            PoliceCar policeCar3 = new PoliceCar("0003 CNP");
            Console.WriteLine(policeCar3.WriteMessage("Created"));
            centralStation.RegisterPoliceCar(policeCar3);
            SpeedRadar radar3 = new SpeedRadar();
            policeCar3.SetRadar(radar3);
            policeCar3.StartPatrolling();
            Console.WriteLine(" ");

            //aunque no hace falta
            Scooter scooter1 = new Scooter();
            Console.WriteLine(scooter1.WriteMessage("Created"));
            scooter1.StartRide();
            scooter1.StopRide();

            Console.WriteLine("     ");


            //Coche con radar utiliza el radar
            policeCar1.UseRadar(taxi1);
            Console.WriteLine("     ");


            taxi2.StartRide();
            policeCar2.UseRadar(taxi2);



            policeCar3.UseRadar(taxi3);
            Console.WriteLine("     ");


            taxi1.StartRide();
            policeCar1.UseRadar(taxi1);
            Console.WriteLine("     ");


            madrid.RemoveTaxiLicense(taxi1);
            Console.WriteLine("     ");

            policeCar1.EndPatrolling();
            policeCar2.EndPatrolling();
            policeCar3.EndPatrolling();
            Console.WriteLine("     ");

            //El coche de policía no tendrá este historial ya que no tenía radar
            policeCar1.PrintRadarHistory();
            policeCar2.PrintRadarHistory();
            policeCar3.PrintRadarHistory();


        }
    }
}