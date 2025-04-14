using Exam4modul.Bot.Dal.Entities;
using Exam4modul.Bot.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam4modul.Bot.Bll.Services;

public class UserInfoService : IUserInfoService
{
    private readonly MainContext mainContext;

    public UserInfoService(MainContext mainContext)
    {
        this.mainContext = mainContext;
    }

    public async Task<long> AddUserInfoAsync(UserInfo userInfo)
    {
        try
        {
            await mainContext.UserInfos.AddAsync(userInfo);
            await mainContext.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return 0l;
        }

        return userInfo.UserInfoId;
    }

    public async Task<UserInfo> GetUserInfoByBotUserIdAsync(long botUserId)
    {
        var userInfo = await mainContext.UserInfos.FirstOrDefaultAsync(ui => ui.BotUserId == botUserId);
        return userInfo;
    }

    public async Task<long> GetUserInfoIdByBotUserIdAsync(long botUserId)
    {
        var userInfo = await mainContext.UserInfos.FirstOrDefaultAsync(ui => ui.BotUserId == botUserId);

        if (userInfo == null) return 0l;

        return userInfo.UserInfoId;
    }

    public Task UpdateUserInfoAsync(UserInfo userInfo)
    {
        throw new NotImplementedException();
    }
}
