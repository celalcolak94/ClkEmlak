using ClkEmlak.BusinessLayer.Abstract;
using ClkEmlak.DtoLayer.MessageDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClkEmlak.WebUI.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IMessageService _messageService;

        public ContactController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(ResultMessageDto resultMessageDto)
        {
            if (ModelState.IsValid)
            {
                await _messageService.TCreateAsync(resultMessageDto);
                ViewBag.Message = "Mesaj Başarılı Bir Şekilde Gönderildi.";
            }

            return View();
        }
    }
}
