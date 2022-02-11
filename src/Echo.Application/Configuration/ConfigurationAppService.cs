using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Echo.Configuration.Dto;

namespace Echo.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : EchoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
