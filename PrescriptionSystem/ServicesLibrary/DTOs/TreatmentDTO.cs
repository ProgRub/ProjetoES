using System;
using ComponentsLibrary.Entities;

namespace ServicesLibrary.DTOs
{
    public class TreatmentDTO : PrescriptionItemDTO
    {
        public BodyPart BodyPart { get; set; }
        public TimeSpan Duration { get; set; }
        public int AgeMinimum { get; set; }
        public int AgeMaximum { get; set; }
    }
}