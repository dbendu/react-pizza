using DatabaseContext.Entities;
using Domain.Pizza.Models;

namespace DataAccess.Mappers.EntityMappers
{
    internal interface IPizzaComponentMapper
    {
        public PizzaComponentDto ToDto(PizzaComponentEntity components);
    }

    internal class PizzaComponentMapper : IPizzaComponentMapper
    {
        public PizzaComponentDto ToDto(PizzaComponentEntity component)
        {
            return new PizzaComponentDto(
                Name: component.Name,
                Weight: component.Weight,
                Price: component.Price);
        }
    }
}
