namespace ship_management.Models
{
    public class Tanker_ship : Ship
    {
        public List<FuelTank> Tanks = new List<FuelTank>();

        public Tanker_ship(int IMO_number, string name, double length, int width) : base(IMO_number, name, length, width)
        {
            
        }

        public void AddFuelTank(double capacity, Fuels fuelType)
        {
            var tank = new FuelTank(capacity, fuelType);
            Tanks.Add(tank);
        }

        public void RefuelTank(int tankIndex, double amount)
        {
            if (tankIndex < 0 || tankIndex >= Tanks.Count) throw new ArgumentOutOfRangeException("Tank index is invalid");
            if (amount <= 0) throw new ArgumentException("Negative amount of fuel");
            Tanks[tankIndex].Refuel(amount);
        }

        public void EmptyTank(int tankIndex)
        {
            if (tankIndex < 0 || tankIndex >= Tanks.Count) throw new ArgumentOutOfRangeException("Tank index is invalid");

            Tanks[tankIndex].Empty();
        }
    }
}
