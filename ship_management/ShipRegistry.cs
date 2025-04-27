
namespace ship_management
{
    public class ShipRegistry
    {
        public List<Ship> Ships { get; set; }

        public ShipRegistry()
        {
            Ships = new List<Ship>();
        }

        public void AddShip(Ship newShip)
        {
            if (!ValidateIMONumber(newShip.IMO_number)) throw new ArgumentException("Invalid IMO number.");

            if (Ships.Any(s => s.IMO_number == newShip.IMO_number))
            {
                throw new InvalidOperationException("Ship with this IMO number already exists");
            }

            Ships.Add(newShip);
        }
        private bool ValidateIMONumber(int number)
        {
            int checkSum = 0;
            int multiplier = 7;
            string imoString = number.ToString();
            for (int i = 0; i < 6; i++)
            {
                checkSum += (imoString[i] - '0') * multiplier;
                multiplier--;
            }

            int lastDigitOfCheckSum = checkSum % 10;
            int lastDigitOfIMO = imoString[imoString.Length - 1] - '0';

            if (imoString.Length == 7 && lastDigitOfCheckSum == lastDigitOfIMO)
            {
                return true;
            }
            return false;
        }
    }
}
