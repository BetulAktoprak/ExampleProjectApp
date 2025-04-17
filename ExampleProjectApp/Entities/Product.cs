namespace ExampleProjectApp.Entities
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; } = default!;
        public decimal UnitPrice { get; set; }
        public string Barcode { get; set; } = default!;
        public int Stock { get; set; }
        public string Description { get; set; } = string.Empty;
        public double Kilo { get; set; }
        public double Metre { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
