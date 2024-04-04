using ClkEmlak.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClkEmlak.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly IEstateService _estateService;
        private readonly IMessageService _messageService;

        public DashboardController(IEstateService estateService, IMessageService messageService)
        {
            _estateService = estateService;
            _messageService = messageService;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.EstateCountForSale = await _estateService.TEstateCountByForSale();
            ViewBag.EstateCountForRent = await _estateService.TEstateCountByForRent();
            ViewBag.MessageCount = await _messageService.TComingMessageCount();
            return View();
        }
    }
}
