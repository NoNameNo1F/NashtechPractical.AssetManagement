using NashtechPractical.AssetManagement.Shared.SeedWork;

namespace NashtechPractical.AssetManagement.Core.Entities.Employees;

public class Employee : IEntity<Guid>, IAggregateRoot, ITrackable
{
    public Guid Id { get; set; }
    // hehe
    
    public DateTime CreatedDateTime { get; set; }
    public DateTime UpdatedDateTime { get; set; }
}