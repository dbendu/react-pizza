using System.Collections.Generic;

namespace Domain.Pizza.Models
{
    public record PizzaDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IReadOnlyCollection<PizzaOption> PizzaOptions { get; set; }

        public record PizzaOption(
            int Diameter,
            bool ThinDoughAvailable,
            IReadOnlyCollection<PizzaComponentDto> Components);
    }
}
