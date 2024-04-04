using ClkEmlak.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClkEmlak.WebUI.Controllers
{
    [AllowAnonymous]
    public class RealEstateController : Controller
    {
        private readonly IEstateService _estateService;

        public RealEstateController(IEstateService estateService, IImageService imageService)
        {
            _estateService = estateService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _estateService.TEstateListByStatusTrue();
            return View(values);
        }

        public async Task<IActionResult> RealEstateForSale()
        {
            var values = await _estateService.TEstateListByForSale();
            return View(values);
        }
        public async Task<IActionResult> RealEstateForRent()
        {
            var values = await _estateService.TEstateListByForRent();
            return View(values);
        }

        public async Task<IActionResult> Details(int id)
        {
            var value = await _estateService.TGetByIdEstateWithImage(id);
            return View(value);
        }
    }
}
