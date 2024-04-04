using ClkEmlak.BusinessLayer.Abstract;
using ClkEmlak.DtoLayer.ContactDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClkEmlak.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class AdminContactController : Controller
	{
		private readonly IContactService _contactService;

        public AdminContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public async Task<IActionResult> Index()
		{
			var value = await _contactService.TGetAllAsync();
			return View(value);
		}

		[HttpGet]
		public async Task<IActionResult> UpdateContact(int id)
		{
			var value = await _contactService.TGetByIdAsync(id);
			return View(value);
		}

        [HttpPost]
        public async Task<IActionResult> UpdateContact(ResultContactDto resultContactDto)
        {
			await _contactService.TUpdateAsync(resultContactDto);
            return RedirectToAction("Index");
        }
    }
}
