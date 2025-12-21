using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Contact
    {
        [Display(Name = "Введите имя")]
        [Required(ErrorMessage = "Необходимо ввести имя")]
        public required string Name { get; set; }


        [Display(Name = "Введите фамилию")]
        [Required(ErrorMessage = "Необходимо ввести фамилию")]
        public required string Surname { get; set; }


        [Display(Name = "Введите возраст")]
        [Required(ErrorMessage = "Необходимо ввести возраст")]
        public int Age { get; set; }


        [Display(Name = "Введите почту")]
        [Required(ErrorMessage = "Необходимо ввести почту"), EmailAddress]
        public required string Email { get; set; }


        [Display(Name = "Введите сообщение")]
        [Required(ErrorMessage = "Необходимо ввести сообщение")]
        [StringLength(500, ErrorMessage = "Длина сообщения должна быть не более 500 символов")]
        public required string Message { get; set; }
    }
}