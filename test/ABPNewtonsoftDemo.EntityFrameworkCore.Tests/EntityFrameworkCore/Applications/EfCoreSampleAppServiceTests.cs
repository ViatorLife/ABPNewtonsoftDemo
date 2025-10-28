using ABPNewtonsoftDemo.Samples;
using Xunit;

namespace ABPNewtonsoftDemo.EntityFrameworkCore.Applications;

[Collection(ABPNewtonsoftDemoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ABPNewtonsoftDemoEntityFrameworkCoreTestModule>
{

}
