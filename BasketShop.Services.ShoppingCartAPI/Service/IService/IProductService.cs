using BasketShop.Services.ShoppingCartAPI.Models.Dto;

namespace BasketShop.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
