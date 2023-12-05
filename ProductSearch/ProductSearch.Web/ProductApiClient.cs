using ProductSearch.Core;

namespace ProductSearch.Web
{
    public class ProductApiClient(HttpClient httpClient)
    {
        public async Task<Product> GetProductsByNameAsync(string productName)
        {
            return await httpClient.GetFromJsonAsync<Product>($"/GetProductsByNameAsync?productName={productName}");
        }
    }
}
