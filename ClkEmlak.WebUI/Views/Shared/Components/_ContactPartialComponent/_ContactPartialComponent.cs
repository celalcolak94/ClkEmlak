using ClkEmlak.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ClkEmlak.WebUI.Views.Shared.Components._ContactMessagePartialComponent
{
    public class _ContactPartialComponent : ViewComponent
    {
        private readonly IContactService _contactService;

        public _ContactPartialComponent(IContactService contactService)
        {
            _contactService = contactService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _contactService.TGetAllAsync();
            return View(value);
        }
    }
}
