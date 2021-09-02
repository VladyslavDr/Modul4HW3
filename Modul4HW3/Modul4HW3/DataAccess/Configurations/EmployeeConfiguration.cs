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
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee").HasKey(p => p.EmployeeId);
            builder.Property(p => p.EmployeeId).HasColumnName("EmployeeId").IsRequired();
            builder.Property(p => p.FirstName).HasColumnName("FirstName").HasMaxLength(50).IsRequired();
            builder.Property(p => p.LastName).HasColumnName("LastName").HasMaxLength(50).IsRequired();
            builder.Property(p => p.HiredData).HasColumnName("HiredData").HasMaxLength(7).IsRequired();
            builder.Property(p => p.DataOfBirth).HasColumnName("DataOfBirth");
            builder.HasOne(d => d.Office)
                .WithMany(p => p.Employes)
                .HasForeignKey(d => d.OfficeId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(d => d.Title)
                .WithMany(p => p.Employes)
                .HasForeignKey(d => d.TitleId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
