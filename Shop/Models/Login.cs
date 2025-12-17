using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Login
    {
        [Display(Name = "Ввведите свой юзернейм")]
        [Required(ErrorMessage = "Необходимо ввести юзернейм")]
        public required string Username { get; set; }


        [Display(Name = "Введите пароль")]
        [Required(ErrorMessage = "Необходимо ввести свой пароль")]
        public required string Password { get; set; }
    }
}