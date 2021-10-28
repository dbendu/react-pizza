using System.Collections.Generic;

namespace ReactPizza.Api.Controllers.Pizza.Responses
{
    public record GetPizzaResponse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IReadOnlyCollection<PizzaResponseSizes> Sizes { get; set; }

        public record PizzaResponseSizes(
            int Diameter,
            int Price,
            bool ThinDoughAvailable);
    };
}
