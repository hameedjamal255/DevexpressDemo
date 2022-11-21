using Abp.AspNetCore.Mvc.ViewComponents;

namespace ReportTestDEvexpress.Web.Views
{
    public abstract class ReportTestDEvexpressViewComponent : AbpViewComponent
    {
        protected ReportTestDEvexpressViewComponent()
        {
            LocalizationSourceName = ReportTestDEvexpressConsts.LocalizationSourceName;
        }
    }
}
