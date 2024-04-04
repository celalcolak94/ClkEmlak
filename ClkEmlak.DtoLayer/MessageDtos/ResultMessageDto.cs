using System.ComponentModel.DataAnnotations;

namespace ClkEmlak.DtoLayer.MessageDtos
{
    public class ResultMessageDto
    {
        public int MessageID { get; set; }

        [Required(ErrorMessage = "Bu Alan Boş Geçilemez.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bu Alan Boş Geçilemez.")]
        [EmailAddress(ErrorMessage = "Lütfen Email Formatında Giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Konu Alanı Boş Geçilemez.")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Mesaj Alanı Boş Geçilemez.")]
        public string MessageDetail { get; set; }
    }
}
