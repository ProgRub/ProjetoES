using System.Collections.Generic;
using ComponentsLibrary.Entities;
using ServicesLibrary.DifferentServices;

namespace ServicesLibrary.DTOs
{
    public class HealthCareProfessionalDTO:UserDTO

    {
        public static HealthCareProfessionalDTO ConvertHealthCareProfessionalToDTO(
            HealthCareProfessional healthCareProfessional)
        {
            var healthCareProfessionalDTO = new HealthCareProfessionalDTO
            {
                Id = healthCareProfessional.Id,
                FullName = healthCareProfessional.FullName,
                DateOfBirth = healthCareProfessional.DateOfBirth,
                HealthUserNumber = healthCareProfessional.HealthUserNumber,
                PhoneNumber = healthCareProfessional.PhoneNumber
            };
            var userMedicalConditions =
                UserService.Instance.GetUsersMedicalConditionsByUserId(healthCareProfessionalDTO.Id);
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
            healthCareProfessionalDTO.Allergies = allergies;
            healthCareProfessionalDTO.Diseases = diseases;
            healthCareProfessionalDTO.MissingBodyParts = UserService.Instance.GetUserMissingBodyPartsByUserId(healthCareProfessionalDTO.Id);
            return healthCareProfessionalDTO;
        }
    }
}