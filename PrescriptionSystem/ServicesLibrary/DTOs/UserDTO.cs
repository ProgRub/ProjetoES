using System;
using System.Collections;
using System.Collections.Generic;

namespace ServicesLibrary.DTOs
{
    public class UserDTO:ItemDTO
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int PhoneNumber { get; set; }
        public int HealthUserNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public IEnumerable<MedicalConditionDTO> Allergies { get; set; }
        public IEnumerable<MedicalConditionDTO> Diseases { get; set; }
    }
}