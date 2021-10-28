using Domain.Pizza.Commands;

namespace ReactPizza.Api.Controllers.Pizza.Mappers
{
    public interface IPizzaControllerRequestsMapper
    {
        GetPizzasCommand ToCommand(int page, int size);
    }

    internal class PizzaControllerRequestsMapper : IPizzaControllerRequestsMapper
    {
        public GetPizzasCommand ToCommand(int page, int size)
        {
            //TODO: validation
            return new GetPizzasCommand(
                Skip: (page - 1) * size,
                Take: size);
        }
    }
}
