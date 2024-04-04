using ClkEmlak.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ClkEmlak.WebUI.Views.Shared.Components._HomePopularEstatePartialComponent
{
    public class _HomePopularEstatePartialComponent : ViewComponent
    {
        private readonly IEstateService _estateService;

        public _HomePopularEstatePartialComponent(IEstateService estateService)
        {
            _estateService = estateService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _estateService.TEstateListByHomePage();
            return View(value);
        }
    }
}
