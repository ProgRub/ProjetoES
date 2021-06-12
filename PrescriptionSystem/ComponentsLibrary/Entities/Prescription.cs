using System;
using System.Collections.Generic;
using ComponentsLibrary.Entities.PrescriptionItems;

namespace ComponentsLibrary.Entities
{
    public class Prescription: Item
    {
        public HealthCareProfessional Author { get; set; }
        public int AuthorId { get; set; }
        public Patient Patient { get; set; }
        public int PatientId { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<PrescriptionHasPrescriptionItems> PrescriptionHasPrescriptionItemsCollection { get; set; }
        public ICollection<PrescriptionHasViewers> PrescriptionHasViewersCollection { get; set; }
    }
}