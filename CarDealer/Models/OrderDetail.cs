namespace CarDealer.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int CarId { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;
        public Car Car { get; set; } = null!;
    }
}