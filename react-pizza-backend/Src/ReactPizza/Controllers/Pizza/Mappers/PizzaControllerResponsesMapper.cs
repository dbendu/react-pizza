using System.Collections.Generic;
using System.Linq;
using BusinessLogic.Services.Pizza.Models;
using ReactPizza.Api.Controllers.Pizza.Responses;

namespace ReactPizza.Api.Controllers.Pizza.Mappers
{
    public interface IPizzaControllerResponsesMapper
    {
        IReadOnlyCollection<GetPizzaResponse> ToResponse(IReadOnlyCollection<PizzaModel> pizzas);
    }

    internal class PizzaControllerResponsesMapper : IPizzaControllerResponsesMapper
    {
        public IReadOnlyCollection<GetPizzaResponse> ToResponse(IReadOnlyCollection<PizzaModel> pizzas)
        {
            return pizzas
                .Select(p => MapToResponse(p))
                .ToArray();
        }

        private static GetPizzaResponse MapToResponse(PizzaModel pizza)
        {
            return new GetPizzaResponse
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Description = pizza.Description,
                Sizes = MapToSizesResponse(pizza.Sizes)
            };
        }

        private static IReadOnlyCollection<GetPizzaResponse.PizzaResponseSizes> MapToSizesResponse(
            IReadOnlyCollection<PizzaModel.PizzaSizeModel> sizes)
        {
            return sizes
                .Select(s => new GetPizzaResponse.PizzaResponseSizes(
                    Diameter: s.Diameter,
                    Price: s.Price,
                    ThinDoughAvailable: s.ThinDoughAvailable))
                .ToArray();
        }
    }
}
