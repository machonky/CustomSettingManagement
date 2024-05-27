using CustomSettingManagement.Samples;
using Xunit;

namespace CustomSettingManagement.EntityFrameworkCore.Applications;

[Collection(CustomSettingManagementTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<CustomSettingManagementEntityFrameworkCoreTestModule>
{

}
