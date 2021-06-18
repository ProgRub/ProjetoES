using System;
using System.Collections;
using System.Collections.Generic;
using ComponentsLibrary.Entities;

namespace ServicesLibrary.DTOs
{
    public class PrescriptionDTO : ItemDTO
    {
        public HealthCareProfessionalDTO Author { get; set; }
        public PatientDTO Patient { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public IEnumerable<PrescriptionItemDTO> PrescriptionItems { get; set; }
        public IEnumerable<HealthCareProfessionalDTO> Viewers { get; set; }
    }
}