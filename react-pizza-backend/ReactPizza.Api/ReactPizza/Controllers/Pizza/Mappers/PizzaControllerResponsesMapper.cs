using System.Collections.Generic;
using System.Linq;
using BusinessLogic.Services.Pizza.Models;
using ReactPizza.Api.Controllers.Pizza.Responses;

namespace ReactPizza.Api.Controllers.Pizza.Mappers
{
    public interface IPizzaControllerResponsesMapper
    {
        IReadOnlyCollection<GetPizzaResponse> ToResponse(IReadOnlyCollection<PizzaModel> pizzas);

        IReadOnlyCollection<GetPizzaCategoryResponse> ToResponse(IReadOnlyCollection<PizzaCategoryModel> pizzas);
    }

    internal class PizzaControllerResponsesMapper : IPizzaControllerResponsesMapper
    {
        public IReadOnlyCollection<GetPizzaResponse> ToResponse(IReadOnlyCollection<PizzaModel> pizzas)
        {
            return pizzas
                .Select(p => new GetPizzaResponse(
                    id: p.Id,
                    name: p.Name,
                    description: p.Description,
                    imageSrc: p.ImageSrc,
                    rating: p.Rating,
                    category: p.Category,
                    sizes: MapToSizesResponse(p.Sizes)))
                .ToArray();
        }

        public IReadOnlyCollection<GetPizzaCategoryResponse> ToResponse(IReadOnlyCollection<PizzaCategoryModel> categories)
        {
            return categories
                .Select(c => new GetPizzaCategoryResponse(
                    Id: c.Id,
                    Value: c.Value))
                .ToArray();
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
