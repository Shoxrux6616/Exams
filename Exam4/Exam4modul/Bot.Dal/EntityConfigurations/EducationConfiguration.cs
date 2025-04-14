using Exam4modul.Bot.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam4modul.Bot.Dal.EntityConfigurations;

public class EducationConfiguration : IEntityTypeConfiguration<Education>
{
    public void Configure(EntityTypeBuilder<Education> builder)
    {
        builder.ToTable("Education");
        builder.HasKey(e => e.EducationId);

        builder.Property(e => e.Institution).IsRequired(false);
        builder.Property(e => e.Degree).IsRequired(false);
        builder.Property(e => e.StartDate).IsRequired(false);
        builder.Property(e => e.EndDate).IsRequired(false);
    }
}
