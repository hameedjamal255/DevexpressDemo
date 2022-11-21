using System.Threading.Tasks;
using Abp.Application.Services;
using ReportTestDEvexpress.Sessions.Dto;

namespace ReportTestDEvexpress.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
