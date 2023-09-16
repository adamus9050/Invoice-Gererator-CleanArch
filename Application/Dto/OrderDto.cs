

namespace Application.Dto
{
    public class OrderDto 
    {
        public int OrderId { get; set; } = default;

        public int CustomerId { get; set; }
        public string? CustomerName { get; set; } = default;
        public string? Surname { get; set; } = default;
        public string? PhoneNumber { get; set; } = default;
        public string? EmailAdres { get; set; } = default;

        public int MaterialId { get; set; }
        public string MaterialName { get; set; } = null!;
        public string MaterialDescription { get; set; } = null!;
        public double MaterialPrice { get; set; }

        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string Type { get; set; } = null!;
        public int ProductPrice { get; set; } 

    }
}