namespace NashtechPractical.AssetManagement.Shared.Infrastructure;

public interface IUnitOfWork
{
    Task<int> CommitAsync(CancellationToken cancellationToken);
}