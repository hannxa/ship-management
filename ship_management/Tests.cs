using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.Win32;
using Xunit;
namespace ship_management
{
    public class Tests
    {
        private ShipRegistry registry;
        public Tests()
        {
            registry = new ShipRegistry();
        }

        [Fact]
        public void Register_Ship_Correctly()
        {
            var ship = new Passenger_ship(9074729, "aab", 121, 32);
            registry.AddShip(ship);

            Assert.Contains(ship, registry.Ships);
        }

        [Fact]
        public void Incorrect_IMO_Number()
        {
            var ship = new Passenger_ship(122413, "aab", 121, 32);
            
            Assert.Throws<ArgumentException>(() => registry.AddShip(ship));

        }

        [Fact]
        public void Duplicate_IMO()
        {
            var ship1 = new Passenger_ship(9074729, "aab", 121, 32);
            var ship2 = new Passenger_ship(9074729, "aab", 121, 32);

            registry.AddShip(ship1);

            Assert.Throws<InvalidOperationException>(() => registry.AddShip(ship2));
        }

        [Fact]
        public void Incorrect_Ship_Length()
        {
            Assert.Throws <ArgumentException>(() => new Passenger_ship(1231232, "ss", -9, 22));
        }

        [Fact]
        public void Adding_Passenger()
        {
            var passengerShip = new Passenger_ship(9074729, "Fuel Carrier", 200, 40);

            registry.AddShip(passengerShip);
            passengerShip.AddPassenger("passenger1");

            Assert.Contains("passenger1", passengerShip.Passengers);
        }

        [Fact]
        public void Removing_Passenger()
        {
            var passengerShip = new Passenger_ship(9074729, "Fuel Carrier", 200, 40);

            registry.AddShip(passengerShip);
            passengerShip.AddPassenger("passenger1");
            passengerShip.RemovePassenger("passenger1");

            Assert.DoesNotContain("passenger1", passengerShip.Passengers);
        }
    }
}
