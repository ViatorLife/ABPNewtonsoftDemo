using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using ABPNewtonsoftDemo.Localization;

namespace ABPNewtonsoftDemo.Web;

[Dependency(ReplaceServices = true)]
public class ABPNewtonsoftDemoBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<ABPNewtonsoftDemoResource> _localizer;

    public ABPNewtonsoftDemoBrandingProvider(IStringLocalizer<ABPNewtonsoftDemoResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
