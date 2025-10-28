using ABPNewtonsoftDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ABPNewtonsoftDemo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ABPNewtonsoftDemoController : AbpControllerBase
{
    protected ABPNewtonsoftDemoController()
    {
        LocalizationResource = typeof(ABPNewtonsoftDemoResource);
    }
}
