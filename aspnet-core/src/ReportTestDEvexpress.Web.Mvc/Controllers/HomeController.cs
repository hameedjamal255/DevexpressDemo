using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using ReportTestDEvexpress.Controllers;
using ReportTestDEvexpress.Web.Reports;

namespace ReportTestDEvexpress.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ReportTestDEvexpressControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
        public IActionResult ParentChildReport()
        {
            string Attribute= "397,398,399,400,401";
            int From = 0;
            int To = 0;
            string FilterString = "";
            var report = new ParentReport();

            report.Parameters["ProjectId"].Value = 181;
            report.Parameters["ProjectId"].Visible = false;

            report.Parameters["AttributeId"].Value = Attribute;
            report.Parameters["AttributeId"].Visible = false;

            report.Parameters["BudgetFilter"].Value = FilterString;
            report.Parameters["BudgetFilter"].Visible = false;

            report.Parameters["From"].Value = From;
            report.Parameters["From"].Visible = false;

            report.Parameters["To"].Value = To;
            report.Parameters["To"].Visible = false;

            return View(report);
        }
    }
}
