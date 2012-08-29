namespace MvcApplication1.Models
{
    public class ProductViewModel
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Price { get; private set; }

        public ProductViewModel(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}