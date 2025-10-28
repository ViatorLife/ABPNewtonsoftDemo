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
}
