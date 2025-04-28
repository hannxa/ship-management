namespace ship_management.Models
{
    public class Passenger_ship : Ship
    {
        public List<string> Passengers = new List<string>();
        public Passenger_ship(int IMO_number, string name, double length, int width) : base (IMO_number, name, length, width)
        {
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
