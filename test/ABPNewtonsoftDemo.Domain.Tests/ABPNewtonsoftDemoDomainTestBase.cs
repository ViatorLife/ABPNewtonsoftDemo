using Volo.Abp.Modularity;

namespace ABPNewtonsoftDemo;

/* Inherit from this class for your domain layer tests. */
public abstract class ABPNewtonsoftDemoDomainTestBase<TStartupModule> : ABPNewtonsoftDemoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
