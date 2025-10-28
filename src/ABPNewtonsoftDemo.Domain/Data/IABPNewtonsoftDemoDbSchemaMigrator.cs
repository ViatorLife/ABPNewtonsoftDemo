using System.Threading.Tasks;

namespace ABPNewtonsoftDemo.Data;

public interface IABPNewtonsoftDemoDbSchemaMigrator
{
    Task MigrateAsync();
}
