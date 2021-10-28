using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Services.Pizza.Models;
using DataAccess.Repositories;
using Domain.Pizza.Commands;

namespace BusinessLogic.Services.Pizza
{
    public interface IPizzaService
    {
        Task<IReadOnlyCollection<PizzaModel>> GetPizzas(GetPizzasCommand command);
    }

    internal class PizzaService : IPizzaService
    {
        private readonly IPizzaRepository _repository;

        public PizzaService(IPizzaRepository repository)
        {
            _repository = repository;
        }

        public async Task<IReadOnlyCollection<PizzaModel>> GetPizzas(GetPizzasCommand command)
        {
            var pizzas = await _repository.GetPizzas(command);

            return pizzas.Select(p =>
            {
                var sizes = p.PizzaOptions
                    .Select(option => new PizzaModel.PizzaSizeModel(
                        Diameter: option.Diameter,
                        Price: option.Components.Sum(c => c.Price),
                        ThinDoughAvailable: option.ThinDoughAvailable))
                    .ToArray();

                return new PizzaModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Sizes = sizes
                };
            }).ToArray();
        }
    }
}
