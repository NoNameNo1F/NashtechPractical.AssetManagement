using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NashtechPractical.AssetManagement.Core.Entities.Users;

namespace Microsoft.Extensions.DependencyInjection.Domain;

public class UserEntityTypeConfiguration :IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.HasKey(u => u.StaffCode);

        builder.Property(u => u.StaffCode)
            .IsRequired()
            .HasColumnName("StaffCode");
        
        builder.Property(u => u.FirstName)
            .HasMaxLength(128)
            .HasColumnName("FirstName");
        
        builder.Property(u => u.LastName)
            .HasMaxLength(128)
            .HasColumnName("LastName");
        
        builder.Property(u => u.DateOfBirth)
            .IsRequired()
            .HasColumnName("DateOfBirth");
        
        builder.Property(u => u.JoinedDate)
            .IsRequired()
            .HasColumnName("JoinedDate");
    }
}