using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ABPNewtonsoftDemo.Data;

/* This is used if database provider does't define
 * IABPNewtonsoftDemoDbSchemaMigrator implementation.
 */
public class NullABPNewtonsoftDemoDbSchemaMigrator : IABPNewtonsoftDemoDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
