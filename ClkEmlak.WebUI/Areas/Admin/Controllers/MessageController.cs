using ClkEmlak.BusinessLayer.Abstract;
using ClkEmlak.DtoLayer.MessageDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClkEmlak.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
    public class MessageController : Controller
	{
		private readonly IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public async Task<IActionResult> Index()
		{
			var value = await _messageService.TGetAllAsync();
			return View(value);
		}

		[HttpGet]
		public async Task<IActionResult> RemoveMessage(int id)
		{
			var value = await _messageService.TGetByIdAsync(id);
			return View(value);
		}

        [HttpPost]
        public async Task<IActionResult> RemoveMessage(ResultMessageDto resultMessageDto)
        {
            await _messageService.TRemoveAsync(resultMessageDto);
            return RedirectToAction("Index");
        }
    }
}
