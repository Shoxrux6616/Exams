using Exam4modul.Bot.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam4modul.Bot.Dal.EntityConfigurations;

public class ProjectConfiguration : IEntityTypeConfiguration<Project>
{
    public void Configure(EntityTypeBuilder<Project> builder)
    {
        builder.ToTable("Project");

        builder.HasKey(p => p.ProjectId);

        builder.Property(p => p.Name).IsRequired(false);
        builder.Property(p => p.Description).IsRequired(false);
        builder.Property(p => p.StartingTime).IsRequired(false);
        builder.Property(p => p.EndingTime).IsRequired(false);
    }
}
