using System.Collections.Generic;
using ComponentsLibrary.Entities;
using ServicesLibrary.DifferentServices;

namespace ServicesLibrary.DTOs
{
    public class TherapistDTO : HealthCareProfessionalDTO

    {
        internal static TherapistDTO ConvertTherapistToDTO(Therapist therapist)
        {
            var therapistDTO = new TherapistDTO
            {
                Id = therapist.Id,
                FullName = therapist.FullName,
                DateOfBirth = therapist.DateOfBirth,
                HealthUserNumber = therapist.HealthUserNumber,
                PhoneNumber = therapist.PhoneNumber
            };
            var userMedicalConditions =
                UserService.Instance.GetUsersMedicalConditionsByUserId(therapistDTO.Id);
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

            therapistDTO.Allergies = allergies;
            therapistDTO.Diseases = diseases;
            therapistDTO.MissingBodyParts = UserService.Instance.GetUserMissingBodyPartsByUserId(therapistDTO.Id);
            return therapistDTO;
        }
    }
}