namespace DatabaseContext.Entities
{
    public record PizzaCatalogComponentsEntity
    {
        public int CatalogId { get; set; }
        public PizzasCatalogEntity Catalog { get; set; }

        public int ComponentId { get; set; }
        public PizzaComponentEntity Component { get; set; }
    }
}
