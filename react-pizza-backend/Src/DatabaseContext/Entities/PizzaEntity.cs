using DatabaseContext.Enums;

namespace DatabaseContext.Entities
{
    public record PizzaEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public PizzaCategory Category { get; set; }
    }
}
