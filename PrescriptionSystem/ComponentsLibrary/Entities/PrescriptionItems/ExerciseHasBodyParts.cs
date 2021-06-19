namespace ComponentsLibrary.Entities.PrescriptionItems
{
    public class ExerciseHasBodyParts : Item
    {
        public Exercise Exercise { get; set; }
        public BodyPart BodyPart { get; set; }
    }
}