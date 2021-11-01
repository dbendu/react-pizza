using System.Collections.Generic;
using DatabaseContext.Enums;

namespace DatabaseContext.Entities
{
    public record PizzasCatalogEntity
    {
        public int Id { get; set; }

        public int PizzaId { get; set; }
        public ProductEntity Pizza { get; set; }

        public int Diameter { get; set; }

        public bool ThinDoughAvailable { get; set; }

        public PizzaCategory Category { get; set; }

        public ICollection<PizzaCatalogComponentsEntity> Components { get; set; }
    }
}
