using System.Collections.Generic;
using System.Threading.Tasks;
using JwtProjeClient.Models;

namespace JwtProjeClient.ApiServices.Interfaces{
    public interface IProductApiService
    {
        Task<List<ProductList>> GetAllAsync();
        Task AddAsync(ProductAdd productAdd);

        Task<ProductList> GetByIdAsync(int id);

        Task UpdateAsync(ProductList productList);

        Task DeleteAsync(int id);

    }
}