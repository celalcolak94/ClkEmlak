using ClkEmlak.BusinessLayer.Abstract;
using ClkEmlak.DtoLayer.CategoryDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClkEmlak.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

		public CategoryController(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

		public async Task<IActionResult> Index()
        {
            var value = await _categoryService.TGetAllAsync();
            return View(value);
        }

        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(ResultCategoryDto resultCategoryDto)
        {
            if (ModelState.IsValid)
            {
				await _categoryService.TCreateAsync(resultCategoryDto);
				return RedirectToAction("Index");
			}
            return View(resultCategoryDto);
        }

		[HttpGet]
		public async Task<IActionResult> UpdateCategory(int id)
		{
            var value = await _categoryService.TGetByIdAsync(id);
			return View(value);
		}

		[HttpPost]
        public async Task<IActionResult> UpdateCategory(ResultCategoryDto resultCategoryDto)
        {
            if (ModelState.IsValid)
            {
				await _categoryService.TUpdateAsync(resultCategoryDto);
				return RedirectToAction("Index");
			}
            return View(resultCategoryDto);
        }

        [HttpGet]
        public async Task<IActionResult> RemoveCategory(int id)
        {
            var value = await _categoryService.TGetByIdAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> RemoveCategory(ResultCategoryDto resultCategoryDto)
        {
            await _categoryService.TRemoveAsync(resultCategoryDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> ChangeStatus(int id)
        {
            await _categoryService.TChangeCategoryStatus(id);
            return RedirectToAction("Index");
        }
    }
}
