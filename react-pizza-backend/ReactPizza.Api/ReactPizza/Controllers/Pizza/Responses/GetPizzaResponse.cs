using System.Collections.Generic;
using Domain.Pizza.Enums;

namespace ReactPizza.Api.Controllers.Pizza.Responses
{
    public record GetPizzaResponse
    {
        public GetPizzaResponse(
            int id,
            string name,
            string description,
            string imageSrc,
            int rating,
            PizzaCategory category,
            IReadOnlyCollection<PizzaResponseSizes> sizes)
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

        public IReadOnlyCollection<PizzaResponseSizes> Sizes { get; set; }

        public record PizzaResponseSizes(
            int Diameter,
            int Price,
            bool ThinDoughAvailable);
    };
}
