using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modul4HW3.Entities;

namespace Modul4HW3.DataAccess.Configurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project").HasKey(p => p.ProjectId);
            builder.Property(p => p.ProjectId).HasColumnName("Project").IsRequired();
            builder.Property(p => p.Name).HasColumnName("Name").HasMaxLength(50).IsRequired();
            builder.Property(p => p.BudGet).HasColumnName("BudGet").HasColumnType("money").IsRequired();
            builder.Property(p => p.StartedDate).HasColumnName("StartedDate").HasMaxLength(7).IsRequired();
        }
    }
}
