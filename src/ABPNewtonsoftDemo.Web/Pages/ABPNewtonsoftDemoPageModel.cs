using ABPNewtonsoftDemo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ABPNewtonsoftDemo.Web.Pages;

public abstract class ABPNewtonsoftDemoPageModel : AbpPageModel
{
    protected ABPNewtonsoftDemoPageModel()
    {
        LocalizationResourceType = typeof(ABPNewtonsoftDemoResource);
    }
}
