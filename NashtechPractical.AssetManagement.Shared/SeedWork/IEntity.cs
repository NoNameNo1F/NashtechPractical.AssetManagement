namespace NashtechPractical.AssetManagement.Shared.SeedWork;

public interface IEntity<T>
{
    public T Id { get; set; }
}