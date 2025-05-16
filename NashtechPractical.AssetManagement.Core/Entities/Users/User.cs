using NashtechPractical.AssetManagement.Core.Enums;
using NashtechPractical.AssetManagement.Shared.SeedWork;

namespace NashtechPractical.AssetManagement.Core.Entities.Users;

public class User : IEntity<Guid>, IAggregateRoot
{
    public Guid Id { get; set; }
    public string StaffCode { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime JoinedDate { get; set; }
    public Boolean Gender { get; set; }
    public ERoles Type { get; set; }
    public ELocations Location { get; set; }
}