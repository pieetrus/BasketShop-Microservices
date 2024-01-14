using BasketShop.Services.RewardAPI.Message;

namespace BasketShop.Services.RewardAPI.Services
{
    public interface IRewardService
    {
        Task UpdateRewards(RewardsMessage rewardsMessage);
    }
}
