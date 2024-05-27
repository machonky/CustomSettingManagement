using System.Threading.Tasks;

namespace CustomSettingManagement.Data;

public interface ICustomSettingManagementDbSchemaMigrator
{
    Task MigrateAsync();
}
