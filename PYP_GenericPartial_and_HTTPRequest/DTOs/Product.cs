using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PYP_GenericPartial_and_HTTPRequest.DTOs
{
    public class ProductsData
    {
        public List<Product> Products { get; set; }
        public int Total { get; set; }  
        public int Skip { get; set; }
        public int Limit { get; set; }
    }

    public class Product
    {
        [JsonPropertyName("thumbnail")]
        public string Image { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double DiscountPercentage { get; set; }
        public string Brand { get; set; }
    }
}
