namespace ship_management
{
    public class Ship
    {
        private int Ship_number { get; set; }
        private string Ship_name { get; set; }
        private double Length {get; set; }
        private double Width { get; set; }


        public Ship(int number, string name, double length, int width)
        {
            Ship_number = number;
            Ship_name = name;
            Length = length;
            Width = width;
        }
    }
}
