using Microsoft.AspNetCore.Mvc;

namespace ClkEmlak.WebUI.Views.Shared.Components._HomeServicePartialComponent
{
    public class _HomeServicePartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
