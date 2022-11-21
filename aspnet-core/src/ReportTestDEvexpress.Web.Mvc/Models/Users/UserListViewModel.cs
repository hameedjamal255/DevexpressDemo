using System.Collections.Generic;
using ReportTestDEvexpress.Roles.Dto;

namespace ReportTestDEvexpress.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
