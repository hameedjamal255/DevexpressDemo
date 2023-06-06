using Microsoft.AspNetCore.Mvc;
using ReportTestDEvexpress.Controllers;

namespace ReportTestDEvexpress.Web.Controllers
{
    public class TreeListReportController : ReportTestDEvexpressControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
