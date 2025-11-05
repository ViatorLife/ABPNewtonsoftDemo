using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;

namespace ABPNewtonsoftDemo.Tests;

public interface ITestAppService : IApplicationService, ITransientDependency
{
    Task TestEventAsync(string methodName);
    Task TestNoEventAsync(string methodName);
}
