using System;
using System.Collections.Generic;
using ComponentsLibrary.Entities.PrescriptionItems;

namespace ComponentsLibrary.Entities
{
    public class TherapySession : Item
    {
        public int TherapistId { get; set; }
        public Therapist Therapist { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public DateTime DateTime { get; set; }
        public TimeSpan EstimatedDuration { get; set; }
        public string Note { get; set; }
        public ICollection<TherapySessionHasTreatments> TherapySessionHasTreatmentsCollection { get; set; }
    }
}