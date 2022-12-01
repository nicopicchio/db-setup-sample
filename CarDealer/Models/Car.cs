using System.ComponentModel.DataAnnotations.Schema;

namespace CarDealer.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; } = null!;
        public string Model { get; set; } = null!;
        public int Year { get; set; }
        public string FuelType { get; set; } = null!;
        public int Price { get; set; }

    }
}
