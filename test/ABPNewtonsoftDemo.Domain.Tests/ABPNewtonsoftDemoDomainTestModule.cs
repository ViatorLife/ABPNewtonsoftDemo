using Volo.Abp.Modularity;

namespace ABPNewtonsoftDemo;

[DependsOn(
    typeof(ABPNewtonsoftDemoDomainModule),
    typeof(ABPNewtonsoftDemoTestBaseModule)
)]
public class ABPNewtonsoftDemoDomainTestModule : AbpModule
{

}
