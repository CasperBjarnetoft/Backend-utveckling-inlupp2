namespace Web_api_nosql.Models
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime Modified { get; set; } = DateTime.Now;
        public int Articalnummber { get; set; }
        public string Name { get; set; } 
        public string Description { get; set; }
        public decimal Price { get; set; }

    }
}
