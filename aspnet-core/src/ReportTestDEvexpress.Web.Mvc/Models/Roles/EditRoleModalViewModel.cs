using Abp.AutoMapper;
using ReportTestDEvexpress.Roles.Dto;
using ReportTestDEvexpress.Web.Models.Common;

namespace ReportTestDEvexpress.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
