using Microsoft.VisualBasic.FileIO;

namespace ship_management
{
    public class FuelTank
    {
        public double Capacity { get; set; }
        public double CurrentLevel { get; set; }
        public string FuelType { get; set; }

        private enum Fuels
        {
            Diesel,
            HeavyFuel
        }

        public FuelTank(double capacity, string fuelType)
        {
            if (!Enum.IsDefined(typeof(Fuels), fuelType)) throw new ArgumentException("Invalid fuel type");
            Capacity = capacity;
            FuelType = fuelType;
            CurrentLevel = 0;
        }
    }
}
