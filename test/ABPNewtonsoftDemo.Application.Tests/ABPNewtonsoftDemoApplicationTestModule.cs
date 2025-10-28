using Volo.Abp.Modularity;

namespace ABPNewtonsoftDemo;

[DependsOn(
    typeof(ABPNewtonsoftDemoApplicationModule),
    typeof(ABPNewtonsoftDemoDomainTestModule)
)]
public class ABPNewtonsoftDemoApplicationTestModule : AbpModule
{

}
