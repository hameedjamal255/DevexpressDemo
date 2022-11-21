using System.Collections.Generic;
using ReportTestDEvexpress.Roles.Dto;

namespace ReportTestDEvexpress.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}