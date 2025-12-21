using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Registration
    {
        [Display(Name = "Введите юзернейм который будет виден для всех пользователей")]
        [Required(ErrorMessage = "Обязательное поле для заполнения")]
        public required string Username { get; set; }


        [Display(Name = "Придумайте надежный пароль")]
        [Required(ErrorMessage = "Обязательное поле для заполнения")]
        public required string Password { get; set; }


        [Display(Name = "Введите почту")]
        [Required(ErrorMessage = "Обязательное поле для заполнения"), DataType(DataType.Password)]
        public required string Email { get; set; }
    }
}