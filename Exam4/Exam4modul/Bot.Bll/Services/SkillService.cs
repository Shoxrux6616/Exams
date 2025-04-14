using Exam4modul.Bot.Dal.Entities;
using Exam4modul.Bot.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam4modul.Bot.Bll.Services;

public class SkillService : ISkillService
{
    private readonly MainContext mainContext;

    public SkillService(MainContext mainContext)
    {
        this.mainContext = mainContext;
    }

    public Task<long> AddSkillAsync(Skill skill)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<Skill>> GetSkillsByUserInfoIdAsync(long userInfoId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateSkillAsync(Skill skill)
    {
        throw new NotImplementedException();
    }
}
