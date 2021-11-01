using System.Collections.Generic;
using Domain.Pizza.Enums;

namespace Domain.Pizza.Models
{
    public record PizzaDto
    {
        public PizzaDto(
            int id,
            string name,
            string description,
            string imageSrc,
            int rating,
            PizzaCategory category,
            IReadOnlyCollection<PizzaSize> sizes)
        {
            Id = id;
            Name = name;
            Description = description;
            ImageSrc = imageSrc;
            Rating = rating;
            Category = category;
            Sizes = sizes;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageSrc { get; set; }

        public int Rating { get; set; }

        public PizzaCategory Category { get; set; }

        public IReadOnlyCollection<PizzaSize> Sizes { get; set; }

        public record PizzaSize(
            int Diameter,
            bool ThinDoughAvailable,
            IReadOnlyCollection<PizzaComponentDto> Components);
    }
}
