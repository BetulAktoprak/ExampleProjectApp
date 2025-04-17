namespace ExampleProjectApp.Entities
{
    public class Order : BaseEntity
    {
        public int CustomerId { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public int FisNo { get; set; } = default!;
        public Customer? Customer { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
