using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace CustomSettingManagement.Pages;

public class Index_Tests : CustomSettingManagementWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
