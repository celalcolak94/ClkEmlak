using System.ComponentModel.DataAnnotations;

namespace ClkEmlak.DtoLayer.LoginDtos
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Kullanıcı Adı Boş Geçilemez.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifre Boş Geçilemez.")]
        public string Password { get; set; }
    }
}
