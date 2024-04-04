using Microsoft.AspNetCore.Mvc;

namespace ClkEmlak.WebUI.Views.Shared.Components._HomeSectionPartialComponent
{
    public class _HomeSectionPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
