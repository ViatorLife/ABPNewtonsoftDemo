using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ABPNewtonsoftDemo.Tests;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace ABPNewtonsoftDemo.Controllers;

[ApiController]
[Route("api/test")]
public class TestController : AbpControllerBase
{
    private readonly ITestAppService _testAppService;

    public TestController(ITestAppService testAppService)
    {
        _testAppService = testAppService;
    }

    [HttpPost("test-list")]
    public async Task<List<string>> TestListAsync()
    {
        await _testAppService.TestEventAsync(methodName: "TestListAsync");
        return new List<string> { "Test1", "Test2", "Test3" };
    }

    [HttpPost("test-string")]
    public async Task<string> TestStringAsync()
    {
        await _testAppService.TestEventAsync(methodName: "TestStringAsync");
        return "TestStringAsync";
    }

    [HttpPost("test-void")]
    public async Task TestVoidAsync()
    {
        await _testAppService.TestEventAsync(methodName: "TestVoidAsync");
    }

    [HttpPost("test-list-no-event")]
    public async Task<List<string>> TestListNoEventAsync()
    {
        await _testAppService.TestNoEventAsync(methodName: "TestListNoEventAsync");
        return new List<string> { "Test1NoEvent", "Test2NoEvent", "Test3NoEvent" };
    }

    [HttpPost("test-string-no-event")]
    public async Task<string> TestStringNoEventAsync()
    {
        await _testAppService.TestNoEventAsync(methodName: "TestStringNoEventAsync");
        return "TestStringNoEventAsync";
    }

    [HttpPost("test-void-no-event")]
    public async Task TestVoidNoEventAsync()
    {
        await _testAppService.TestNoEventAsync(methodName: "TestVoidNoEventAsync");
    }
}
