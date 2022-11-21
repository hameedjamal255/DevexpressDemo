using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ReportTestDEvexpress.Configuration.Dto;

namespace ReportTestDEvexpress.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ReportTestDEvexpressAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
