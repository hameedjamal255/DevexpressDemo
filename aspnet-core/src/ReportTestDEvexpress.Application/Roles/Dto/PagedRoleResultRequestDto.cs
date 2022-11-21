using Abp.Application.Services.Dto;

namespace ReportTestDEvexpress.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

