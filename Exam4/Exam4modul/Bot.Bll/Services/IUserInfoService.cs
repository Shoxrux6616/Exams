using Exam4modul.Bot.Dal.Entities;

namespace Exam4modul.Bot.Bll.Services
{
    public interface IUserInfoService
    {
        Task<long> AddUserInfoAsync(UserInfo userInfo);
        Task UpdateUserInfoAsync(UserInfo userInfo);
        Task<long> GetUserInfoIdByBotUserIdAsync(long botUserId);
        Task<UserInfo> GetUserInfoByBotUserIdAsync(long botUserId);
    }
}