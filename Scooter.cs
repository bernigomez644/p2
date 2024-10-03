using Practice1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    internal class Scooter : NoPlateVehicle
    {
       
        private static string typeOfVehicle = "Scooter";
        private bool riding;
        

        public Scooter() : base(typeOfVehicle)
        {
            riding = false;
        }

        public void StartRide()
        {
            SetSpeed(45.0f);
            riding = true;
            Console.WriteLine(WriteMessage("start riding."));
        }
        public void StopRide()
        {
            if (riding)
            {
                riding = false;
                SetSpeed(0f);
                Console.WriteLine(WriteMessage("stops riding."));
            }
            else
            {
                Console.WriteLine(WriteMessage("already stop."));
            }
        }
    }
}
