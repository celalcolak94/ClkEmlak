using ClkEmlak.BusinessLayer.Abstract;
using ClkEmlak.DtoLayer.SocialMediaDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClkEmlak.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SocialMediaController : Controller
    {
        private readonly ISocialMediaService _socialMediaService;

        public SocialMediaController(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public async Task<IActionResult> Index()
        {
            var value = await _socialMediaService.TGetAllAsync();
            return View(value);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateSocialMedia(int id)
        {
            var value = await _socialMediaService.TGetByIdAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateSocialMedia(ResultSocialMediaDto resultSocialMediaDto)
        {
            await _socialMediaService.TUpdateAsync(resultSocialMediaDto);
            return RedirectToAction("Index");
        }
    }
}
