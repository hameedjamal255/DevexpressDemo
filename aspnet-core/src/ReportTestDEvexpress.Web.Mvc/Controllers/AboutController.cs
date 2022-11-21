using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using ReportTestDEvexpress.Controllers;

namespace ReportTestDEvexpress.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : ReportTestDEvexpressControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
