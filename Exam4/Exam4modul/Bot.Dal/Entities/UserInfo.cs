using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam4modul.Bot.Dal.Entities;

public class UserInfo
{
    public long UserInfoId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public string Summary { get; set; }

    public long BotUserId { get; set; }
    public BotUser BotUser { get; set; }

    public ICollection<Education> Educations { get; set; }
    public ICollection<Experience> Experiences { get; set; }
    public ICollection<Skill> Skills { get; set; }
    public ICollection<Project> Projects { get; set; }
}
