namespace LAb4Task1.Models
{
    public enum CarType
    {
        Petrol, diesel, electric, hybrid, flintstone
    }
    public class Car
    {
        // atttributes
        public string Make { get; set; }
        public string Model { get; set; }

        public int EngineSize { get; set; }

        public CarType VechType { get; set; }
    }
}

