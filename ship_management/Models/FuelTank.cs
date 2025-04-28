using Microsoft.VisualBasic.FileIO;

namespace ship_management.Models
{
    public enum Fuels
    {
        Diesel,
        HeavyFuel
    }
    public class FuelTank
    {
        public double Capacity { get; set; }
        public double CurrentLevel { get; set; }
        public Fuels FuelType { get; set; }

        private int Index { get; set; }

        public FuelTank(double capacity, Fuels fuelType)
        {
            if (!Enum.IsDefined(typeof(Fuels), fuelType)) throw new ArgumentException("Invalid fuel type");
            Capacity = capacity;
            FuelType = fuelType;
            CurrentLevel = 0;
        }

        public void Refuel(double amount)
        {
            if (amount <= 0) throw new ArgumentException("Amount must be positive");
            if (CurrentLevel + amount > Capacity) throw new InvalidOperationException("Cannot overfill the tank");
            CurrentLevel += amount;
        }

        public void Empty()
        {
            CurrentLevel = 0;
        }
    }
}
