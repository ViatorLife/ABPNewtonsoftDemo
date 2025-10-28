using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ABPNewtonsoftDemo.Data;
using Volo.Abp.DependencyInjection;

namespace ABPNewtonsoftDemo.EntityFrameworkCore;

public class EntityFrameworkCoreABPNewtonsoftDemoDbSchemaMigrator
    : IABPNewtonsoftDemoDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreABPNewtonsoftDemoDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the ABPNewtonsoftDemoDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ABPNewtonsoftDemoDbContext>()
            .Database
            .MigrateAsync();
    }
}
