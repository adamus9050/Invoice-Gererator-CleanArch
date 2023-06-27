
namespace Application.Dto
{
    public class MaterialDto
    {
        public int Id { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public double Price { get; set; }
    }
}
