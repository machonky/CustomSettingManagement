using CustomSettingManagement.Samples;
using Xunit;

namespace CustomSettingManagement.EntityFrameworkCore.Domains;

[Collection(CustomSettingManagementTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<CustomSettingManagementEntityFrameworkCoreTestModule>
{

}
