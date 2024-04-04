using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace ClkEmlak.WebUI.Views.Shared.Components._UILayoutPageNavbarPartialComponent
{
    public class _UILayoutPageNavbarPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var path = HttpContext.Request.Path;
            var segments = path.Value.Split('/');
            var capturedSegment = segments[1];
            if (capturedSegment == "RealEstate")
            {
                ViewBag.path = "Gayrimenkuller";
            }
            else if(capturedSegment == "Service")
            {
                ViewBag.path = "Hizmetler";
            }
            else if (capturedSegment == "About")
            {
                ViewBag.path = "Hakkımızda";
            }
            else if (capturedSegment == "Contact")
            {
                ViewBag.path = "İletişim";
            }
            return View();
        }
    }
}
