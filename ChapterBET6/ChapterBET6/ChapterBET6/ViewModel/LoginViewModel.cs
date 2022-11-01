using System.ComponentModel.DataAnnotations;

namespace ChapterBET6.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "E-mail Requerido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Senha Requerido")]
        public string Senha { get; set; }
    }
}
