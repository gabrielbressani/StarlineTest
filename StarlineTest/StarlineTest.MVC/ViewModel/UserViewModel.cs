using System;
using System.ComponentModel.DataAnnotations;

namespace StarlineTest.MVC.ViewModel
{
    public class UserViewModel
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "O campo \"Nome\" é obrigatório.")]
        [MaxLength(200, ErrorMessage = "O campo \"Nome\" pode ter no máximo 200 caracteres.")]
        public string Nome { get; set; }

        public bool Active { get; set; }

        [ScaffoldColumn(false)]
        public DateTime RegistrationDate { get; set; }
    }
}