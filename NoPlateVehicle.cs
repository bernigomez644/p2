using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice1;
using Practice2;

namespace Practice1
{
    abstract class NoPlateVehicle : Vehicle
    {
        protected NoPlateVehicle(string typeOfVehicle) : base(typeOfVehicle) { }
        public override string GetPlate()
        {
            return "Vehicle has no plate";
        }

        public override string ToString()
        {
            return $"{GetTypeOfVehicle()} with no plate";
        }
    }
}
