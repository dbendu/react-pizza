using System.Collections.Generic;

namespace DatabaseContext.Entities
{
    public record PizzasCatalogEntity
    {
        public int Id { get; set; }

        public int PizzaId { get; set; }
        public PizzaEntity Pizza { get; set; }

        public int Diameter { get; set; }

        public bool ThinDoughAvailable { get; set; }

        public ICollection<PizzaCatalogComponentsEntity> Components { get; set; }
    }
}
