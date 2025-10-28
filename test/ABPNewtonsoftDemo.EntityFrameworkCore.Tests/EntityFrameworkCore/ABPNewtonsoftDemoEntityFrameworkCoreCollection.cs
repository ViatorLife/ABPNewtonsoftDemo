using Xunit;

namespace ABPNewtonsoftDemo.EntityFrameworkCore;

[CollectionDefinition(ABPNewtonsoftDemoTestConsts.CollectionDefinitionName)]
public class ABPNewtonsoftDemoEntityFrameworkCoreCollection : ICollectionFixture<ABPNewtonsoftDemoEntityFrameworkCoreFixture>
{

}
