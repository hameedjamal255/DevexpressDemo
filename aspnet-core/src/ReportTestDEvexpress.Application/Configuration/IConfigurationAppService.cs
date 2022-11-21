using System.Threading.Tasks;
using ReportTestDEvexpress.Configuration.Dto;

namespace ReportTestDEvexpress.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
