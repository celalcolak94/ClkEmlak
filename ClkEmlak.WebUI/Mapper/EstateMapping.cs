using AutoMapper;
using ClkEmlak.DtoLayer.EstateDtos;
using ClkEmlak.EntityLayer.Entities;
using ClkEmlak.WebUI.Models;

namespace ClkEmlak.WebUI.Mapper
{
	public class EstateMapping : Profile
	{
		public EstateMapping()
		{
			CreateMap<Estate, ResultEstateDto>().ReverseMap();
			CreateMap<Estate, EstateWithCategoryDto>().ReverseMap();

			//Create İşlemleri
			CreateMap<CreateEstateModel, ResultEstateDto>()
			.ForMember(dest => dest.ImageUrls, opt => opt.MapFrom(src => MapImages(src.Images)));
			CreateMap<ResultEstateDto, CreateEstateModel>()
			.ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.ImageUrls));
			CreateMap<ResultEstateDto, Estate>()
			.ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.ImageUrls.Select(url => new Image { ImageUrl = url }).ToList()));
			CreateMap<Estate, ResultEstateDto>()
			.ForMember(dest => dest.ImageUrls, opt => opt.MapFrom(src => src.Images.Select(url => url.ImageUrl).ToList()));
		}

		private List<string> MapImages(List<IFormFile> images)
		{
			var imageUrls = new List<string>();
			if (images != null)
			{
				foreach (var image in images)
				{
					// Resim dosya yolunu oluştur
					string imageExtension = Path.GetExtension(image.FileName);
					string imageName = Guid.NewGuid() + imageExtension;
					string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/{imageName}");

					// Resmi dosyaya kaydet
					using var stream = new FileStream(path, FileMode.Create);
					image.CopyTo(stream);

					// Resmin URL'sini listeye ekle
					imageUrls.Add("/images/" + imageName);
				}
			}

			return imageUrls;
		}
	}
}
