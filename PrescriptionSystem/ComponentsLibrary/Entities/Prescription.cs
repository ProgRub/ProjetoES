using System;
using System.Collections.Generic;

namespace ComponentsLibrary.Entities
{
    public class Prescription: Item
    {
        public int AuthorId { get; set; }
        public int PatientId { get; set; }
        public IEnumerable<int> ViewersIDs { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public IDictionary<int,IEnumerable<TimeSpan>> RecommendedTimes { get; set; }
        public IEnumerable<int> PrescriptionItems { get; set; }
    }
}