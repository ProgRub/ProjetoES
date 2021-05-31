using System;

namespace ComponentsLibrary.Entities.PrescriptionItems
{
    public class Treatment:PrescriptionItem
    {
        public BodyPart BodyPart { get; set; }
        public TimeSpan Duration { get; set; }
        public int AgeMinimum { get; set; }
        public int AgeMaximum { get; set; }
    }
}