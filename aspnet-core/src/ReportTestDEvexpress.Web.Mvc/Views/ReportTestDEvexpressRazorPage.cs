using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace ReportTestDEvexpress.Web.Views
{
    public abstract class ReportTestDEvexpressRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ReportTestDEvexpressRazorPage()
        {
            LocalizationSourceName = ReportTestDEvexpressConsts.LocalizationSourceName;
        }
    }
}
