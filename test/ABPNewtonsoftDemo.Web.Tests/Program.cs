using Microsoft.AspNetCore.Builder;
using ABPNewtonsoftDemo;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("ABPNewtonsoftDemo.Web.csproj"); 
await builder.RunAbpModuleAsync<ABPNewtonsoftDemoWebTestModule>(applicationName: "ABPNewtonsoftDemo.Web");

public partial class Program
{
}
