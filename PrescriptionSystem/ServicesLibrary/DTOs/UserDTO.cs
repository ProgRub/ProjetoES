using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ComponentsLibrary.Entities;
using ServicesLibrary.DifferentServices;

namespace ServicesLibrary.DTOs
{
    public class UserDTO:ItemDTO
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int PhoneNumber { get; set; }
        public int HealthUserNumber { get; set; }
        public IEnumerable<MedicalConditionDTO> Allergies { get; set; }
        public IEnumerable<MedicalConditionDTO> Diseases { get; set; }
        public IEnumerable<BodyPart> MissingBodyParts { get; set; }

        internal static UserDTO ConvertUserToDTO(User user)
        {
            var userDTO = new UserDTO
            {
                Id = user.Id, FullName = user.FullName, DateOfBirth = user.DateOfBirth,
                HealthUserNumber = user.HealthUserNumber, PhoneNumber = user.PhoneNumber
            };
            var userMedicalConditions =
                UserService.Instance.GetUsersMedicalConditionsByUserId(userDTO.Id);
            var allergies = new List<MedicalConditionDTO>();
            var diseases = new List<MedicalConditionDTO>();
            foreach (var medicalCondition in userMedicalConditions)
            {
                switch (medicalCondition.Type)
                {
                    case MedicalConditionDTO.Allergy:
                        allergies.Add(MedicalConditionDTO.ConvertMedicalConditionToDTO(medicalCondition));
                        break;
                    case MedicalConditionDTO.Disease:
                        diseases.Add(MedicalConditionDTO.ConvertMedicalConditionToDTO(medicalCondition));
                        break;
                }
            }
            userDTO.Allergies = allergies;
            userDTO.Diseases = diseases;
            userDTO.MissingBodyParts = UserService.Instance.GetUserMissingBodyPartsByUserId(userDTO.Id);
            return userDTO;
        }
    }
}