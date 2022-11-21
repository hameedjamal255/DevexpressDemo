using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ReportTestDEvexpress.Controllers
{
    public abstract class ReportTestDEvexpressControllerBase: AbpController
    {
        protected ReportTestDEvexpressControllerBase()
        {
            LocalizationSourceName = ReportTestDEvexpressConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
