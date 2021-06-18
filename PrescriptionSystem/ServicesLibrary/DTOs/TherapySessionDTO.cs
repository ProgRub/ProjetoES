using System;
using System.Collections.Generic;

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

    }
}