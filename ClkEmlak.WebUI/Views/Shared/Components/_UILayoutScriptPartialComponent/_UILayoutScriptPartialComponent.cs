using Microsoft.AspNetCore.Mvc;

namespace ClkEmlak.WebUI.Views.Shared.Components._UILayoutScriptPartialComponent
{
    public class _UILayoutScriptPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
