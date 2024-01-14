using BasketShop.Services.EmailAPI.Message;
using BasketShop.Services.EmailAPI.Models.Dto;

namespace BasketShop.Services.EmailAPI.Services
{
    public interface IEmailService
    {
        Task EmailCartAndLog(CartDto cartDto);
        Task RegisterUserEmailAndLog(string email);
        Task LogOrderPlaced(RewardsMessage rewardsDto);
    }
}
