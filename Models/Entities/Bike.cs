namespace BikeShop.Models.Entities
{
    public class Bike
    {
        public int BikeId {get; set; }
        
        public string Name { get; set; }

        public string Manufacturer { get; set; }

        public int Gears { get; set; }

        public string Type { get; set; }

        public string Gender { get; set; }

        public string Picture {get; set; }

        public double Price { get; set; }
    }
}