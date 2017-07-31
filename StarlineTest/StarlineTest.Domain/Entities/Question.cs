using StarlineTest.Domain.Enumerators;
using System;

namespace StarlineTest.Domain.Entities
{
    public class Question
    {
        public int QuestionId { get; set; }

        public TypeOfQuestion TypeOfQuestion { get; set; }

        public string Enunciated { get; set; }
        public string Answers { get; set; }

        public DateTime RegistrationDate { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
