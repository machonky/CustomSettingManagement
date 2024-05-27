using Microsoft.AspNetCore.Builder;
using CustomSettingManagement;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<CustomSettingManagementWebTestModule>();

public partial class Program
{
}
