using System.Collections.Generic;
using ReportTestDEvexpress.Roles.Dto;

namespace ReportTestDEvexpress.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
