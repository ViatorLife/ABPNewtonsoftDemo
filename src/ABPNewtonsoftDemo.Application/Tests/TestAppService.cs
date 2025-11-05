using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus.Local;

namespace ABPNewtonsoftDemo.Tests;

public class TestAppService : ApplicationService, ITestAppService
{
    private readonly ILocalEventBus _localEventBus;
    private readonly IRepository<TestRecord, Guid> _testRecordRepository;

    public TestAppService(ILocalEventBus localEventBus, IRepository<TestRecord, Guid> testRecordRepository)
    {
        _localEventBus = localEventBus;
        _testRecordRepository = testRecordRepository;
    }

    public async Task TestEventAsync(string methodName)
    {
        await _localEventBus.PublishAsync(new TestEvent()
        {
            MethodName = methodName
        });
    }

    public async Task TestNoEventAsync(string methodName)
    {
        var dateTime = DateTime.Now;
        var testRecords = new List<TestRecord>();
        for (int i = 0; i < 10000; i++)
        {
            testRecords.Add(new TestRecord(name: methodName, value: i.ToString() + " " + dateTime.ToString("yyyy-MM-dd HH:mm:ss.fff")));
        }
        await _testRecordRepository.InsertManyAsync(testRecords);
    }
}
