using Microsoft.VisualBasic.FileIO;

namespace ship_management
{
    public class FuelTank
    {
        public double Capacity { get; set; }
        public double CurrentLevel { get; set; }
        public string FuelType { get; set; }

        public FuelTank(double capacity, string fuelType)
        {
            Capacity = capacity;
            FuelType = fuelType;
            CurrentLevel = 0;
        }
    }
}
