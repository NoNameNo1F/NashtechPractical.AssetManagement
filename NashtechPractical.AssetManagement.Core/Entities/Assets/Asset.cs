using NashtechPractical.AssetManagement.Shared.SeedWork;

namespace NashtechPractical.AssetManagement.Core.Entities.Assets;

public class Asset : IEntity<int>, IAggregateRoot
{
    public int Id { get; set; }
}