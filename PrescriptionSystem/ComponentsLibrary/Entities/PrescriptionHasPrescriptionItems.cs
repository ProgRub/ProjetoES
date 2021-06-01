using System;
using ComponentsLibrary.Entities.PrescriptionItems;

namespace ComponentsLibrary.Entities
{
    public class PrescriptionHasPrescriptionItems:Item
    {
        public Prescription Prescription { get; set; }
        public PrescriptionItem PrescriptionItem { get; set; }
        public TimeSpan RecommendedTime { get; set; }
    }
}