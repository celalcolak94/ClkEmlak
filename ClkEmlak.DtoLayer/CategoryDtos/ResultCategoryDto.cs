using System.ComponentModel.DataAnnotations;

namespace ClkEmlak.DtoLayer.CategoryDtos
{
    public class ResultCategoryDto
    {
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "Kategori Adı Boş Geçilemez.")]
        public string Name { get; set; }

		[Required(ErrorMessage = "Bu Alan Boş Geçilemez.")]
		public bool Status { get; set; }
	}
}
