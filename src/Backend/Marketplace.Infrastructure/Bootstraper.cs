using FluentMigrator.Runner;
using Martkeplace.Domain.Extension;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Marketplace.Infrastructurel;

public static class Bootstraper
{
    public static void AddRepository(this IServiceCollection services, IConfiguration configuration)
    {
        AddFluentMigrator(services, configuration);
    }

    private static void AddFluentMigrator(IServiceCollection services, IConfiguration configuration)
    {
        var fullConnection = configuration.GetFullConnection();

        services.AddFluentMigratorCore().ConfigureRunner(c =>
        c.AddMySql5()
        .WithGlobalConnectionString(fullConnection)
        .ScanIn(Assembly.Load("Marketplace.Infrastructure")).For.All());
    }


}
