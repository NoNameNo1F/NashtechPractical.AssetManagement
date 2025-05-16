using System.Reflection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NashtechPractical.AssetManagement.Core.Entities.Users;

namespace Microsoft.Extensions.DependencyInjection.Persistences;

public class AssetDbContext : IdentityDbContext<Account, IdentityRole<Guid>, Guid>
{
    public DbSet<Account> Accounts { get; set; }
    public DbSet<User> Users { get; set; }
    // public DbSet<Category> Categories { get; set; }
    // public DbSet<Assignment> Assignments { get; set; }
    // public DbSet<ReturnRequested> ReturnRequesteds { get; set; }

    public AssetDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        
        modelBuilder.Entity<Account>().ToTable("Accounts");
        modelBuilder.Entity<IdentityRole<Guid>>().ToTable("Roles");
        modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("UserRoles");
        modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("UserClaims");
        modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("UserLogins");
        modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("UserTokens");
        modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("RoleClaims");
    }
}