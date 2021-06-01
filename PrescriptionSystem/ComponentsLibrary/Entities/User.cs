using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComponentsLibrary.Entities
{
    public class User : Item
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int PhoneNumber { get; set; }
        public int HealthUserNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}