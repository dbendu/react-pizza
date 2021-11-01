using System.Collections.Generic;
using System.Linq;
using DataAccess.Mappers.EntityMappers;
using DatabaseContext.Entities;
using Domain.CommonLogic;
using Domain.Pizza.Models;

using ContextCategory = DatabaseContext.Enums.PizzaCategory;
using DomainCategory = Domain.Pizza.Enums.PizzaCategory;

namespace DataAccess.Mappers.RepositoryMappers
{
    internal interface IPizzaRepositoryMapper
    {
        public IReadOnlyCollection<PizzaDto> ToDto(IReadOnlyCollection<PizzasCatalogEntity> pizzaCatalogs);
    }

    internal class PizzaRepositoryMapper : IPizzaRepositoryMapper
    {
        private readonly IPizzaComponentMapper _pizzaComponentMapper;

        public PizzaRepositoryMapper(IPizzaComponentMapper pizzaComponentMapper)
        {
            _pizzaComponentMapper = pizzaComponentMapper;
        }

        public IReadOnlyCollection<PizzaDto> ToDto(IReadOnlyCollection<PizzasCatalogEntity> pizzaCatalogs)
        {
            var groupedByPizza = pizzaCatalogs
                .GroupBy(c => c.PizzaId)
                .ToArray();

            return groupedByPizza
                .Select(p => MapToDto(p))
                .ToArray();
        }

        private PizzaDto MapToDto(IGrouping<int, PizzasCatalogEntity> pizzaCatalogs)
        {
            var pizza = pizzaCatalogs.First().Pizza;
            var pizzaCategory = pizzaCatalogs.First().Category;

            var sizes = pizzaCatalogs.Select(catalog =>
            {
                var diameter = catalog.Diameter;
                var thinDoughAvailable = catalog.ThinDoughAvailable;

                var components = catalog.Components
                    .Select(c => _pizzaComponentMapper.ToDto(c.Component))
                    .ToArray();

                return new PizzaDto.PizzaSize(
                    Diameter: diameter,
                    ThinDoughAvailable: thinDoughAvailable,
                    Components: components);
            }).ToArray();

            return new PizzaDto(
                id: pizza.Id,
                name: pizza.Name,
                description: pizza.Description,
                imageSrc: pizza.ImageSrc,
                rating: pizza.Rating,
                category: EnumMapper.Map<ContextCategory, DomainCategory>(pizzaCategory),
                sizes: sizes);
        }
    }
}
