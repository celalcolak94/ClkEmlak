using AutoMapper;
using ClkEmlak.BusinessLayer.Abstract;
using ClkEmlak.DataAccessLayer.Abstract;
using ClkEmlak.DtoLayer.EstateDtos;
using ClkEmlak.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClkEmlak.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class EstateController : Controller
	{
		private readonly IEstateService _estateService;
		private readonly IMapper _mapper;

		public EstateController(IEstateService estateService, IEstateDal estateDal, IMapper mapper)
		{
			_estateService = estateService;
			_mapper = mapper;
		}

		public async Task<IActionResult> Index()
		{
			var value = await _estateService.TGetAllAsync();
			return View(value);
		}

		[HttpGet]
		public IActionResult CreateEstate()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> CreateEstate(CreateEstateModel createEstateModel)
		{
			createEstateModel.Date = DateTime.Now;
			var estate = _mapper.Map<ResultEstateDto>(createEstateModel);
			if (estate.ImageUrls.Count != 0)
			{
				estate.CoverPhoto = estate.ImageUrls[0];
			}
			else
			{
				estate.CoverPhoto = "/EstateThema/images/img_1.jpg";
			}
				
			await _estateService.TCreateAsync(estate);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public async Task<IActionResult> UpdateEstate(int id)
		{
			var value = await _estateService.TGetByIdAsync(id);
			var estate = _mapper.Map<CreateEstateModel>(value);
			return View(estate);
		}

		[HttpPost]
		public async Task<IActionResult> UpdateEstate(CreateEstateModel createEstateModel)
		{
			var estate = _mapper.Map<ResultEstateDto>(createEstateModel);
			if (estate.ImageUrls.Count != 0)
				estate.CoverPhoto = estate.ImageUrls[0];
			await _estateService.TUpdateAsync(estate);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public async Task<IActionResult> RemoveEstate(int id)
		{
			var value = await _estateService.TGetByIdAsync(id);
			return View(value);
		}

		[HttpPost]
		public async Task<IActionResult> RemoveEstate(ResultEstateDto resultEstateDto)
		{
			await _estateService.TRemoveAsync(resultEstateDto);
			return RedirectToAction("Index");
		}
	}
}
