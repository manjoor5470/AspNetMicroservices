using Catalog.API.Entities;

namespace Catalog.API.Repositories.Interface
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProduct();

        Task<Product> GetProductById(string id);

        Task<IEnumerable<Product>> GetProductByName(string name);

        Task<IEnumerable<Product>> GetProductByCategory(string category);

        Task CreateProduct(Product product);

        Task<bool> UpdateProduct(Product product);

        Task<bool> DeleteProduct(string id);
    }
}
