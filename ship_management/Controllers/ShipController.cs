using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ship_management.Models;

namespace ship_management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipController : ControllerBase
    {
        private static ShipRegistry shipRegistry = new ShipRegistry();

        // Adding new ship 
        [HttpPost]
        public IActionResult AddShip([FromBody] Ship newShip)
        {
            shipRegistry.AddShip(newShip);
            return Ok("Ship added successfully");
        }

        //Updating passengers
        [HttpPut("passenger/{imoNumber}")]
        public IActionResult UpdatePassengers(int imoNumber, [FromBody] List<string> passengers)
        {
            var ship = shipRegistry.Ships.OfType<Passenger_ship>().FirstOrDefault(s => s.IMO_number == imoNumber);
            if (ship == null)
                return NotFound("Passenger ship not found.");

            ship.Passengers = passengers;
            return Ok("Passengers list updated.");
        }

        //Adding fuel tanks
        [HttpPut("tanker/{imoNumber}/fuel")]
        public IActionResult AddFuelTank(int imoNumber, [FromBody] FuelTank fuelTank)
        {
            var ship = shipRegistry.Ships.OfType<Tanker_ship>().FirstOrDefault(s => s.IMO_number == imoNumber);
            if (ship == null)
                return NotFound("Tanker ship not found.");
            ship.AddFuelTank(fuelTank.Capacity, fuelTank.FuelType);
            return Ok("Fuel tank added to the tanker");
        }

        //Refueing tank
        [HttpPut("tanke/{imoNumber}/fuel/{tankIndex}")]
        public IActionResult RefuelTank (int imoNumber, int tankIndex, [FromBody] double amount)
        {
            var ship = shipRegistry.Ships.OfType<Tanker_ship>().FirstOrDefault(s => s.IMO_number == imoNumber);
            if (ship == null)
                return NotFound("Tanker ship not found.");

            try
            {
                ship.RefuelTank(tankIndex, amount);
                return Ok("Tank refueled successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Emptying tank
        [HttpPut("tanker/{imoNumber}/fuel/{tankIndex}/empty")]
        public IActionResult EmptyTank(int imoNumber, int tankIndex)
        {
            var ship = shipRegistry.Ships.OfType<Tanker_ship>().FirstOrDefault(s => s.IMO_number == imoNumber);
            if (ship == null)
                return NotFound("Tanker ship not found.");

            try
            { 
                ship.EmptyTank(tankIndex);
                return Ok("Tank emptied successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
