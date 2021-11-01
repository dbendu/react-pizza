using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Services.Pizza.Models;
using BusinessLogic.Settings;
using DataAccess.Repositories;
using Domain.Pizza.Commands;
using Domain.Pizza.Enums;
using Domain.Pizza.Models;
using Microsoft.Extensions.Options;

namespace BusinessLogic.Services.Pizza
{
    public interface IPizzaService
    {
        Task<IReadOnlyCollection<PizzaModel>> GetPizzas(GetPizzasCommand command);

        IReadOnlyCollection<PizzaCategoryModel> GetPizzaCategories();
    }

    internal class PizzaService : IPizzaService
    {
        private readonly IPizzaRepository _repository;
        private readonly IOptions<MediaProviderSettings> _mediaProviderSettings;

        public PizzaService(
            IPizzaRepository repository,
            IOptions<MediaProviderSettings> mediaProviderSettings)
        {
            _repository = repository;
            _mediaProviderSettings = mediaProviderSettings;
        }

        public async Task<IReadOnlyCollection<PizzaModel>> GetPizzas(GetPizzasCommand command)
        {
            var pizzas = await _repository.GetPizzas(command);

            return pizzas.Select(p =>
            {
                var sizes = p.Sizes
                    .Select(option => new PizzaModel.PizzaSizeModel(
                        Diameter: option.Diameter,
                        Price: option.Components.Sum(c => c.Price),
                        ThinDoughAvailable: option.ThinDoughAvailable))
                    .ToArray();

                return new PizzaModel(
                    id: p.Id,
                    name: p.Name,
                    description: p.Description,
                    imageSrc: BuildImageSourcePath(p),
                    rating: p.Rating,
                    category: p.Category,
                    sizes: sizes);
            }).ToArray();
        }

        public IReadOnlyCollection<PizzaCategoryModel> GetPizzaCategories()
        {
            var categories = Enum.GetValues<PizzaCategory>()
                .Select(category => new PizzaCategoryModel(
                    Id: (int)category,
                    Value: category.ToString()))
                .ToArray();

            return categories;
        }

        private string BuildImageSourcePath(PizzaDto pizza)
        {
            var imageSrc = Path.Combine(
                _mediaProviderSettings.Value.BaseUrl,
                _mediaProviderSettings.Value.ImagesDirectory,
                pizza.ImageSrc);

            return imageSrc;
        }
    }
}
