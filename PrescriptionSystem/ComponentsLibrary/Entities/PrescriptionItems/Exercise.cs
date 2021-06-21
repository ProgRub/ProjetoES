using System;
using System.Collections.Generic;

namespace ComponentsLibrary.Entities.PrescriptionItems
{
    public class Exercise:PrescriptionItem
    {
        public TimeSpan Duration { get; set; }
        public int AgeMinimum { get; set; }
        public int AgeMaximum { get; set; }
        public ICollection<BodyPart> BodyParts { get; set; }
    }
}