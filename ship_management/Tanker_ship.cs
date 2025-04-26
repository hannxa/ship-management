namespace ship_management
{
    public class Tanker_ship : Ship
    {
        public List<FuelTank> FuelTanks { get; set; }

        public Tanker_ship(int number, string name, double length, int width) : base(number, name, length, width)
        {
            FuelTanks = new List<FuelTank>();
        }

        public void AddFuelTank(FuelTank tank)
        {
            FuelTanks.Add(tank);
        }
    }
}
