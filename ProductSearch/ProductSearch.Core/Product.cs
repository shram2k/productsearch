namespace ProductSearch.Core
{
    public class Product
    {

        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal? Price { get; set; }
        public int Rating { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public List<string>? Reviews { get; set; }
    }
}
