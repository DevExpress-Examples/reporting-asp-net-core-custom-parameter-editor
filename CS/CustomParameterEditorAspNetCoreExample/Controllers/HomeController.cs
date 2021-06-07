using DevExpress.XtraReports.Native;
using Microsoft.AspNetCore.Mvc;

namespace CustomParameterEditorAspNetCoreExample.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }
        public IActionResult Error() {
            Models.ErrorModel model = new Models.ErrorModel();
            return View(model);
        }

        public ActionResult Designer()
        {
            var report = new PredefinedReports.TestReport();
            report.Extensions[SerializationService.Guid] = CustomDataSerializer.Name;
            return View(report);
        }
        public ActionResult Viewer()
        {
            var report = new PredefinedReports.TestReport();
            report.Extensions[SerializationService.Guid] = CustomDataSerializer.Name;
            return View(report);
        }
    }
}
