namespace ship_management
{
    public class Passenger_ship : Ship
    {
        public List<string> Passengers { get; set; }
        public Passenger_ship(int number, string name, double length, int width) : base (number, name, length, width)
        {
            Passengers = new List<string>();
        }

        public void AddPassenger( string passenger)
        {
            Passengers.Add(passenger);
        }

        public void RemovePassenger(string passenger)
        {
            Passengers.Remove(passenger);
        }
    }
}
