namespace NashtechPractical.AssetManagement.Shared.SeedWork;

public interface ITrackable
{
    public DateTime CreatedDateTime { get; set; }
    public DateTime UpdatedDateTime { get; set; }
}