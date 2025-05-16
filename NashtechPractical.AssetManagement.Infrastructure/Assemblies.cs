using System.Reflection;
using NashtechPractical.AssetManagement.WebAPI.Application.Services;

namespace Microsoft.Extensions.DependencyInjection;

public class Assemblies
{
    public static readonly Assembly Application = typeof(AssetQueryService).Assembly;

}