using System.ComponentModel.DataAnnotations;

namespace Restaurante.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o Nome")]
        [Display(Name = "Usuario")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Informe a Senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}
