namespace ComponentsLibrary.Entities.PrescriptionItems
{
    public class ExerciseHasBodyParts : Item
    {
        public Exercise Exercise { get; set; }
        public int ExerciseId { get; set; }
        public BodyPart BodyPart { get; set; }
    }
}