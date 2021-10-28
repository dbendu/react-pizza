using System.Collections.Generic;

namespace BusinessLogic.Services.Pizza.Models
{
    public record PizzaModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IReadOnlyCollection<PizzaSizeModel> Sizes { get; set; }

        public record PizzaSizeModel(
            int Diameter,
            int Price,
            bool ThinDoughAvailable);
    }
        
}
