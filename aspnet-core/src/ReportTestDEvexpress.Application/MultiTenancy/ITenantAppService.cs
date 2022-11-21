using Abp.Application.Services;
using ReportTestDEvexpress.MultiTenancy.Dto;

namespace ReportTestDEvexpress.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

