using System;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;

namespace ServicesLibrary.DTOs
{
    public class TreatmentDTO : PrescriptionItemDTO
    {
        public BodyPart BodyPart { get; set; }
        public TimeSpan Duration { get; set; }
        public int AgeMinimum { get; set; }
        public int AgeMaximum { get; set; }

        public static TreatmentDTO ConvertTreatmentToDTO(Treatment treatment)
        {
            return new TreatmentDTO
            {
                Id = treatment.Id,
                AgeMaximum = treatment.AgeMaximum, AgeMinimum = treatment.AgeMinimum, BodyPart = treatment.BodyPart,
                Name = treatment.Name, Description = treatment.Description, Duration = treatment.Duration
            };
        }
    }
}