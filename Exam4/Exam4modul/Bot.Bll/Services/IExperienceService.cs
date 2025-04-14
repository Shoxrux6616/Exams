using Exam4modul.Bot.Dal.Entities;

namespace Exam4modul.Bot.Bll.Services;

public interface IExperienceService
{
    Task<ICollection<Experience>> GetExperiencesByUserInfoIdAsync(long userInfoId);
    Task<long> AddExperienceAsync(Experience experience);
    Task UpdateExperienceAsync(Experience experience);
}