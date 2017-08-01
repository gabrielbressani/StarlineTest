using StarlineTest.Domain.Enumerators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StarlineTest.MVC.ViewModel
{
    public class QuestionViewModel
    {
        public QuestionViewModel() {}

        public QuestionViewModel(int userID)
        {
            UserId = userID;
        }

        [Key]
        public int QuestionId { get; set; }

        [Required(ErrorMessage = "O campo \"Tipo de Questão\" é obrigatório.")]
        public TypeOfQuestion TypeOfQuestion { get; set; }

        [Required(ErrorMessage = "O campo \"Enunciado\" é obrigatório.")]
        [MaxLength(200, ErrorMessage = "O campo \"Enunciado\" pode ter no máximo 400 caracteres.")]
        public string Enunciated { get; set; }

        [MaxLength(200, ErrorMessage = "O campo \"Respostas\" pode ter no máximo 400 caracteres.")]
        public string Answers { get; set; }

        [ScaffoldColumn(false)]
        public DateTime RegistrationDate { get; set; }

        public int UserId { get; set; }
        public virtual UserViewModel User { get; set; }
    }
}