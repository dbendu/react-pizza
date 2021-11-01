using System.Collections.Generic;
using Domain.Pizza.Enums;

namespace BusinessLogic.Services.Pizza.Models
{
    public record PizzaModel
    {
        public PizzaModel(
            int id,
            string name,
            string description,
            string imageSrc,
            int rating,
            PizzaCategory category,
            IReadOnlyCollection<PizzaSizeModel> sizes)
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

        public int Rating { get; set; }

        public string ImageSrc { get; set; }

        public PizzaCategory Category { get; set; }

        public IReadOnlyCollection<PizzaSizeModel> Sizes { get; set; }

        public record PizzaSizeModel(
            int Diameter,
            int Price,
            bool ThinDoughAvailable);
    }
        
}
