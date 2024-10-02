using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    internal class Alarm: IMessageWritter

    {
        /// khbjhkcbaskjdhcba

        private PoliceStation policeStation;
        private bool activated = false;

        public Alarm (PoliceStation policeStation)
        {
            this.policeStation = policeStation;

        }

        public void activate_alarm(string plate)
        {
            activated = true;
            Console.WriteLine(WriteMessage("Activated!!"));
            ilegalCarNotification(plate);

        }

        public void desactivate_alarm()
        {
            activated = false;
        }

        private void ilegalCarNotification(string plate)
        {
            foreach (PoliceCar policeCar in policeStation.listOfPoliceCars)
            {
                if (policeCar.isPatrolling)
                {
                    policeCar.ilegal_car = plate; 
                }
            }
        }

        public override string ToString()
        {
            return $"Alarm from {policeStation.Name}";
        }

        public string WriteMessage(string message)
        {
            return $"{this}: {message}";
        }

    }
}
