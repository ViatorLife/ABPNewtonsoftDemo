using ABPNewtonsoftDemo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ABPNewtonsoftDemo.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ABPNewtonsoftDemoEntityFrameworkCoreModule),
    typeof(ABPNewtonsoftDemoApplicationContractsModule)
)]
public class ABPNewtonsoftDemoDbMigratorModule : AbpModule
{
}
