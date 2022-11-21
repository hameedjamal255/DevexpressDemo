using Abp.Authorization;
using ReportTestDEvexpress.Authorization.Roles;
using ReportTestDEvexpress.Authorization.Users;

namespace ReportTestDEvexpress.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
