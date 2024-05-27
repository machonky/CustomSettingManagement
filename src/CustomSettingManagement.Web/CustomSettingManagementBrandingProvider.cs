using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace CustomSettingManagement.Web;

[Dependency(ReplaceServices = true)]
public class CustomSettingManagementBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "CustomSettingManagement";
}
