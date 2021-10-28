using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Mappers.RepositoryMappers;
using DatabaseContext;
using Domain.Pizza.Commands;
using Domain.Pizza.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public interface IPizzaRepository
    {
        Task<IReadOnlyCollection<PizzaDto>> GetPizzas(GetPizzasCommand command);
    }

    internal class PizzaRepository : IPizzaRepository
    {
        private readonly ReactPizzaContext _context;

        private readonly IPizzaRepositoryMapper _mapper;

        public PizzaRepository(
            ReactPizzaContext context,
            IPizzaRepositoryMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IReadOnlyCollection<PizzaDto>> GetPizzas(GetPizzasCommand command)
        {
            var pizzaIds = await _context.Pizzas
                .Skip(command.Skip)
                .Take(command.Take)
                .Select(p => p.Id)
                .ToArrayAsync();

            if (!pizzaIds.Any())
                return Array.Empty<PizzaDto>();

            var pizzas = await _context.PizzasCatalog
                .Where(p => pizzaIds.Contains(p.PizzaId))
                .Include(catalog => catalog.Pizza)
                .Include(catalog => catalog.Components)
                    .ThenInclude(c => c.Component)
                .ToArrayAsync();

            return _mapper.ToDto(pizzas);
        }
    }
}
