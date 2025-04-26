namespace ship_management
{
    public class FleetRegistry
    {
        private List<Ship> Ships { get; set; }

        public FleetRegistry()
        {
            Ships = new List<Ship>();
        }
    }
}
