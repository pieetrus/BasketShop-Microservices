using BasketShop.Services.ShoppingCartAPI.Models.Dto;

namespace BasketShop.Services.ShoppingCartAPI.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
