using ABPNewtonsoftDemo.Samples;
using Xunit;

namespace ABPNewtonsoftDemo.EntityFrameworkCore.Domains;

[Collection(ABPNewtonsoftDemoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ABPNewtonsoftDemoEntityFrameworkCoreTestModule>
{

}
