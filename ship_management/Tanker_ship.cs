namespace ship_management
{
    public class Tanker_ship : Ship
    {
        public List<FuelTank> Tanks = new List<FuelTank>();

       
        public Tanker_ship(int number, string name, double length, int width, int numberOfTanks) : base(number, name, length, width)
        {
            for (int i = 0; i< numberOfTanks; i++)
            {
                Tanks.Add(new FuelTank());
            }
        }

        public void AddFuelTank(FuelTank tank)
        {
            Tanks.Add(tank);
        }
    }
}
