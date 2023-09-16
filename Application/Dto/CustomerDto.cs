
namespace Application.Dto
{
    public class CustomerDto
    {
        public int Id { get; set; } = default!;
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EmailAdres { get; set; }
        public string? Street { get; set; }
        public string? NumberOf { get; set; } = null!;
        public string? PostCode { get; set; }
        public string? City { get; set; }

        public bool IsEditable { get; set; }

    }
}
