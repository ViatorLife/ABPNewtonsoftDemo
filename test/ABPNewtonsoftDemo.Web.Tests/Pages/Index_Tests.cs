using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace ABPNewtonsoftDemo.Pages;

[Collection(ABPNewtonsoftDemoTestConsts.CollectionDefinitionName)]
public class Index_Tests : ABPNewtonsoftDemoWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
