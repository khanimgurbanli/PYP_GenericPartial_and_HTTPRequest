using PYP_GenericPartial_and_HTTPRequest.DTOs;
using Refit;

namespace PYP_GenericPartial_and_HTTPRequest.Services.Abstraction;

public interface IProductHttpClient
{
    [Get("/products")]
    Task<ProductsData> GetProductsAsync();

    [Get("/products/{id}")]
    Task<Product> GetProductAsync(int id);
}
