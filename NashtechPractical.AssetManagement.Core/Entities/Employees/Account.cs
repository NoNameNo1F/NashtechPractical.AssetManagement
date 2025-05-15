using NashtechPractical.AssetManagement.Shared.SeedWork;

namespace NashtechPractical.AssetManagement.Core.Entities.Employees;

public class Account : IEntity<Guid> //, IdentityUser
{
    public Guid Id { get; set; }
    public string UserName { get; set; }
    public string HashedPassword { get; set; }
    public Guid EmployeeId { get; set; }
}