using System;
using System.Collections.Generic;
using System.Linq;
using ComponentsLibrary.Entities;
using ServicesLibrary.DifferentServices;

namespace ServicesLibrary.DTOs
{
    public class TherapySessionDTO : ItemDTO
    {
        public TherapistDTO Therapist { get; set; }
        public PatientDTO Patient { get; set; }
        public DateTime DateTime { get; set; }
        public TimeSpan EstimatedDuration { get; set; }
        public string Note { get; set; }
        public IEnumerable<TreatmentDTO> Treatments { get; set; }

        public static TherapySessionDTO ConvertTherapySessionToDTO(TherapySession therapySession)
        {
            var therapySessionDTO = new TherapySessionDTO
            {
                Id = therapySession.Id,
                Patient = PatientDTO.ConvertPatientToDTO((Patient)UserService.Instance.GetUserById(therapySession.PatientId)),
                Therapist = TherapistDTO.ConvertTherapistToDTO((Therapist)UserService.Instance.GetUserById(therapySession.TherapistId)),
                Note = therapySession.Note,
                EstimatedDuration = therapySession.EstimatedDuration,
                DateTime = therapySession.DateTime
            };
            var treatments =
                TherapySessionService.Instance.GetTherapySessionTreatmentsBySessionId(therapySessionDTO.Id);
            therapySessionDTO.Treatments = treatments.Select(treatment => TreatmentDTO.ConvertTreatmentToDTO(treatment)).ToList();

            return therapySessionDTO;
        }

    }
}