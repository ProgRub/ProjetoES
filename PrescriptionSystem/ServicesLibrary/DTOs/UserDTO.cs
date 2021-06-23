using System;
using System.Collections.Generic;
using ComponentsLibrary.Entities;
using ServicesLibrary.DifferentServices;

namespace ServicesLibrary.DTOs
{
    public class UserDTO : ItemDTO
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int PhoneNumber { get; set; }
        public int HealthUserNumber { get; set; }
        public IEnumerable<MedicalConditionDTO> Allergies { get; set; }
        public IEnumerable<MedicalConditionDTO> Diseases { get; set; }
        public IEnumerable<BodyPart> MissingBodyParts { get; set; }
    }
}