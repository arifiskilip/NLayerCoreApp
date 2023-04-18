namespace Core.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }

        public ProductFeature ProductFeature { get; set; }
        public Category Category { get; set; }
    }
}
