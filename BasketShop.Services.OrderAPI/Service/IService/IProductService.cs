
using BasketShop.Services.OrderAPI.Models.Dto;

namespace BasketShop.Services.OrderAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
