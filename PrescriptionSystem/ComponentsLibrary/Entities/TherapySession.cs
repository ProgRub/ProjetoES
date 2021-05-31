using System;
using System.Collections.Generic;

namespace ComponentsLibrary.Entities
{
    public class TherapySession : Item
    {
        public int TherapistId { get; set; }
        public int PatientId { get; set; }
        public DateTime Date { get; set; }
        public IEnumerable<int> TreatmentsIDs { get; set; }
        public IEnumerable<int> CompletedTreatmentsIDs { get; set; }
        public string Note { get; set; }
        public IDictionary<int,string> TreatmentNotes { get; set; }
    }
}