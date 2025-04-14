using Exam4modul.Bot.Dal.Entities;

namespace Exam4modul.Bot.Bll.Services;

public interface IBotUserService
{
    Task AddUserAsync(BotUser user);
    Task UpdateUserAsync(BotUser user);
    Task<List<BotUser>> GetAllUsersAsync();
    Task<BotUser> GetBotUserByTelegramUserIdAsync(long telegramUserId);
    Task<long> GetBotUserIdByTelegramUserIdAsync(long telegramUserId);
}