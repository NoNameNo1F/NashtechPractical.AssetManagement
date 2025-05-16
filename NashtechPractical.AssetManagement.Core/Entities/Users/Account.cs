using Microsoft.AspNetCore.Identity;
using NashtechPractical.AssetManagement.Shared.SeedWork;

namespace NashtechPractical.AssetManagement.Core.Entities.Users;

public class Account : IdentityUser<Guid>
{
    public Guid Id { get; set; }
    public string UserName { get; set; }
    public string HashedPassword { get; set; }
    
    public Guid UserId { get; set; }
}