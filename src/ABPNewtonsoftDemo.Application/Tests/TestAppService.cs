using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.EventBus.Local;

namespace ABPNewtonsoftDemo.Tests;

public class TestAppService : ApplicationService, ITestAppService
{
    private readonly ILocalEventBus _localEventBus;

    public TestAppService(ILocalEventBus localEventBus)
    {
        _localEventBus = localEventBus;
    }

    public async Task TestEventAsync(string methodName)
    {
        await _localEventBus.PublishAsync(new TestEvent()
        {
            MethodName = methodName
        });
    }
}
