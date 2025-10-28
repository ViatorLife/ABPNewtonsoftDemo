using ABPNewtonsoftDemo.Localization;
using Volo.Abp.Application.Services;

namespace ABPNewtonsoftDemo;

/* Inherit your application services from this class.
 */
public abstract class ABPNewtonsoftDemoAppService : ApplicationService
{
    protected ABPNewtonsoftDemoAppService()
    {
        LocalizationResource = typeof(ABPNewtonsoftDemoResource);
    }
}
