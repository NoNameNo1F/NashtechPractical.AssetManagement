using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NashtechPractical.AssetManagement.Core.Entities.Assets;

namespace Microsoft.Extensions.DependencyInjection.Domain;

public class AssetEntityTypeConfiguration : IEntityTypeConfiguration<Asset>
{
    public void Configure(EntityTypeBuilder<Asset> builder)
    {
        builder.ToTable("Assets", "asset");

        builder.HasKey(a => a.Id);
    }
}