using System;
using System.Collections.Generic;
using ComponentsLibrary.Entities.PrescriptionItems;

namespace ComponentsLibrary.Entities
{
    public class TherapySession : Item
    {
        public Therapist Therapist { get; set; }
        public Patient Patient { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public ICollection<TherapySessionHasTreatments> TherapySessionHasTreatmentsCollection { get; set; }
    }
}