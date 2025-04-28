# Ship Management System
Overview
The Ship Management System is a backend API built using C# and ASP.NET Core. The purpose of this system is to manage a fleet of ships, including adding new ships, updating passenger lists for passenger ships, managing fuel tanks for tanker ships, and refueling or emptying fuel tanks. The API supports basic CRUD operations for handling ships and their associated data.

This project is designed to handle two main types of ships:

Passenger Ships: Ships that carry passengers. The API allows updating the list of passengers.

Tanker Ships: Ships that carry fuel in multiple tanks. The API allows adding fuel tanks, refueling them, and emptying them.

## Features
Add Ship: Add a new ship to the registry with a unique IMO number, name, length, and width.

Update Passengers: Update the list of passengers on a passenger ship.

Add Fuel Tanks: Add new fuel tanks to a tanker ship, specifying the type of fuel and capacity.

Refuel Tank: Refuel a specific tank on a tanker ship.

Empty Tank: Empty a specific fuel tank on a tanker ship.

## API Endpoints
1. Add a New Ship
POST /api/ship

Adds a new ship to the registry.

Request body should contain the ship's details (IMO number, name, length, width).

Returns a success message upon successful addition.

2. Update Passengers on a Passenger Ship
PUT /api/ship/passenger/{imoNumber}

Updates the list of passengers for a passenger ship based on the provided IMO number.

Request body should contain a list of passengers (strings).

Returns a success message if passengers were updated.

3. Add Fuel Tank to a Tanker Ship
PUT /api/ship/tanker/{imoNumber}/fuel

Adds a fuel tank to a tanker ship.

Request body should contain the fuel tank's capacity and fuel type (e.g., Diesel, Heavy Fuel).

Returns a success message if the fuel tank was added.

4. Refuel a Tank on a Tanker Ship
PUT /api/ship/tanker/{imoNumber}/fuel/{tankIndex}

Refuels a specific tank on a tanker ship.

Request body should contain the amount of fuel to be added to the tank.

Returns a success message if the tank was refueled successfully.

5. Empty a Tank on a Tanker Ship
PUT /api/ship/tanker/{imoNumber}/fuel/{tankIndex}/empty

Empties a specific tank on a tanker ship.

No request body required.

Returns a success message if the tank was emptied.

## Models
- Ship: Represents a ship with properties like IMO number, name, length, and width.

- PassengerShip: Inherits from Ship and includes a list of passengers.

- Tanker_ship: Inherits from Ship and includes a list of fuel tanks, each with a capacity and fuel type.

- FuelTank: Represents a fuel tank with properties like fuel type, capacity, and current fuel amount.
- ShipRegistry: Manages a collection of ships and ensures that the ships are added to or updated in the registry. It ensures that IMO numbers are unique and handles the storage and retrieval of ship data.
- 
## Tests
The Tests class contains unit tests to verify the core functionality of the Ship Management System. Key test cases include:

- Register_Ship_Correctly: Ensures that ships are successfully registered in the ShipRegistry.

- Incorrect_IMO_Number: Validates that ships with invalid IMO numbers throw exceptions.

- Duplicate_IMO: Checks that ships with duplicate IMO numbers trigger an exception.

- Verifies that ships with negative lengths are rejected.

- Adding_Passenger: Tests adding passengers to a passenger ship.

- Removing_Passenger: Verifies that passengers can be removed from a passenger ship.

- Refueling_Tank: Ensures proper refueling of tanks on tanker ships.

- Emptying_Tank: Tests the functionality of emptying fuel tanks on tanker ships.
  
## Controllers
- ShipController
The main logic for handling requests related to ships is encapsulated in the ShipController class. It provides endpoints for adding ships, updating passengers, managing fuel tanks, and refueling or emptying tanks.

### Key Methods
- AddShip: Adds a new ship to the ship registry.

- UpdatePassengers: Updates the list of passengers for a passenger ship.

- AddFuelTank: Adds a fuel tank to a tanker ship.

- RefuelTank: Refuels a specific tank on a tanker ship.

- EmptyTank: Empties a specific tank on a tanker ship.

