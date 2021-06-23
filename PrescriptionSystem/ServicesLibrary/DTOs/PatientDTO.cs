using System.Collections.Generic;
using ComponentsLibrary.Entities;
using ServicesLibrary.DifferentServices;

namespace ServicesLibrary.DTOs
{
    public class PatientDTO : UserDTO
    {
        internal static PatientDTO ConvertPatientToDTO(Patient patient)
        {
            var patientDTO = new PatientDTO
            {
                Id = patient.Id,
                FullName = patient.FullName,
                DateOfBirth = patient.DateOfBirth,
                HealthUserNumber = patient.HealthUserNumber,
                PhoneNumber = patient.PhoneNumber
            };
            var userMedicalConditions =
                UserService.Instance.GetUsersMedicalConditionsByUserId(patientDTO.Id);
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

            patientDTO.Allergies = allergies;
            patientDTO.Diseases = diseases;
            patientDTO.MissingBodyParts = UserService.Instance.GetUserMissingBodyPartsByUserId(patientDTO.Id);
            return patientDTO;
        }
    }
}