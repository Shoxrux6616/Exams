using Exam4modul.Bot.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam4modul.Bot.Dal.EntityConfigurations;

public class SkillConfiguration : IEntityTypeConfiguration<Skill>
{
    public void Configure(EntityTypeBuilder<Skill> builder)
    {
        builder.ToTable("Skill");

        builder.HasKey(s => s.SkillId);

        builder.Property(s => s.Name).IsRequired(false);
        builder.Property(s => s.ProficiencyLevel).IsRequired(false);
    }
}
