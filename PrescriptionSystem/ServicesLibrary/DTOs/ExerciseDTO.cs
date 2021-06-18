using System;
using System.Collections.Generic;
using ComponentsLibrary.Entities;

namespace ServicesLibrary.DTOs
{
    public class ExerciseDTO:PrescriptionItemDTO
    {
        public TimeSpan Duration { get; set; }
        public int AgeMinimum { get; set; }
        public int AgeMaximum { get; set; }
        public IEnumerable<BodyPart> BodyParts { get; set; }
    }
}