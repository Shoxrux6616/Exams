using Exam4modul.Bot.Dal.Entities;

namespace Exam4modul.Bot.Bll.Services;

public interface ISkillService
{
    Task<ICollection<Skill>> GetSkillsByUserInfoIdAsync(long userInfoId);
    Task<long> AddSkillAsync(Skill skill);
    Task UpdateSkillAsync(Skill skill);
}