using DatabaseContext.Enums;

namespace DatabaseContext.Entities
{
    public record ProductEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ProductCategory Category { get; set; }

        public int Rating { get; set; }

        public string ImageSrc { get; set; }
    }
}
