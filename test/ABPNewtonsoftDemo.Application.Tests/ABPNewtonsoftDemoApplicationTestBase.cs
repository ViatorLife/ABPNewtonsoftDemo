using Volo.Abp.Modularity;

namespace ABPNewtonsoftDemo;

public abstract class ABPNewtonsoftDemoApplicationTestBase<TStartupModule> : ABPNewtonsoftDemoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
