namespace ship_management
{
    public class Tanker_ship : Ship
    {
        public List<FuelTank> FuelTanks = new List<FuelTank>();

       
        public Tanker_ship(int number, string name, double length, int width) : base(number, name, length, width)
        {
            
        }

        public void AddFuelTank(FuelTank tank)
        {
            FuelTanks.Add(tank);
        }
    }
}
