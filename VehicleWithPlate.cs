
namespace Practice2
{
    abstract class VehicleWithPlate : Vehicle
    {
        private string plate;
        protected VehicleWithPlate(string typeOfVehicle, string plate) : base(typeOfVehicle)
        {
            this.plate = plate;
        }
        public override string ToString()
        {
            return $"{GetTypeOfVehicle()} with plate {GetPlate()}";
        }
        public override string GetPlate()
        {
            return plate;
        }
    }
}

