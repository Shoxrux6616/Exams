using Exam4modul.Bot.Dal.Entities;

namespace Exam4modul.Bot.Bll.Services;

public interface IEducationService
{
    Task<ICollection<Education>> GetEducationsByUserInfoIdAsync(long userInfoId);
    Task<long> AddEducationAsync(Education education);
    Task UpdateEducationAsync(Education education);
    Task DeleteEducationAsync(long id, long userInfoId);
}