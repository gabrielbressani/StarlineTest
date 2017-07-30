﻿using System;

namespace StarlineTest.Domain.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Nome { get; set; }
        public bool Active { get; set; }
        public DateTime RegistrationDate { get; set; }

        public bool UserActiveOfThisYear(User user)
        {
            return user.Active && user.RegistrationDate.Year == DateTime.Now.Year;
        }
    }
}
