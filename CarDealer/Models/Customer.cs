namespace CarDealer.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? phone { get; set; }
        public ICollection<Order> Orders { get; set; } = null!;
    }
}
