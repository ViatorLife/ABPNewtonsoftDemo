using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EventBus;

namespace ABPNewtonsoftDemo.Tests;

public class TestEventHandler : ILocalEventHandler<TestEvent>, ITransientDependency
{
    private readonly ILogger<TestEventHandler> _logger;

    public TestEventHandler(ILogger<TestEventHandler> logger)
    {
        _logger = logger;
    }

    public async Task HandleEventAsync(TestEvent eventData)
    {
        _logger.LogWarning($"Start HandleEventAsync:[{eventData.MethodName}]");
        Thread.Sleep(10000);
        _logger.LogWarning($"End HandleEventAsync:[{eventData.MethodName}]");
    }
}

public class TestEvent
{
    public string MethodName { get; set; }
}