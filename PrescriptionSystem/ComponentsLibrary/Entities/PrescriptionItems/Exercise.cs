using System;
using System.Collections.Generic;

namespace ComponentsLibrary.Entities.PrescriptionItems
{
    public class Exercise:PrescriptionItem
    {
        public IEnumerable<BodyPart> BodyParts { get; set; }
        public TimeSpan Duration { get; set; }
        public int AgeMinimum { get; set; }
        public int AgeMaximum { get; set; }
    }
}