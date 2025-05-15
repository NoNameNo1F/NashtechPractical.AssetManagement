using NashtechPractical.AssetManagement.Shared.SeedWork;

namespace NashtechPractical.AssetManagement.Core.Entities.Assignments;

public class Assignment : IEntity<int>, IAggregateRoot, ITrackable
{
    public int Id { get; set; }
    // other field below
    
    public DateTime CreatedDateTime { get; set; }
    public DateTime UpdatedDateTime { get; set; }
}