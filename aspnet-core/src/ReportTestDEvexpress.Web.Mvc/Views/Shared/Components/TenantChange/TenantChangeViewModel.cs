using Abp.AutoMapper;
using ReportTestDEvexpress.Sessions.Dto;

namespace ReportTestDEvexpress.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
