using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic.FileIO;

namespace ship_management.Models
{
    public class Ship
    {
        public int IMO_number { get; set; }
        private string Ship_name { get; set; }
        private double Length {get; set; }
        private double Width { get; set; }
        public enum ShipTypes
        {
            PassengerShip,
            TankerShip
        }

        public Ship(int number, string name, double length, int width)
        {
            if (length <= 0) throw new ArgumentException("Length cannot be negative");
            IMO_number = number;
            Ship_name = name;
            Length = length;
            Width = width;
        }
 
    }
}
