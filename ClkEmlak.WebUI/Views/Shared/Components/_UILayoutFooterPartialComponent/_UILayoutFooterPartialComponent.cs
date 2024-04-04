using ClkEmlak.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ClkEmlak.WebUI.Views.Shared.Components._UILayoutFooterPartialComponent
{
    public class _UILayoutFooterPartialComponent : ViewComponent
    {
        private readonly IContactService _contactService;
        private readonly ISocialMediaService _socialMediaService;

        public _UILayoutFooterPartialComponent(IContactService contactService, ISocialMediaService socialMediaService)
        {
            _contactService = contactService;
            _socialMediaService = socialMediaService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var socialMedias = await _socialMediaService.TGetAllAsync();
            ViewBag.SocialMedias = socialMedias;

            var value = await _contactService.TGetAllAsync();
            return View(value);
        }
    }
}
