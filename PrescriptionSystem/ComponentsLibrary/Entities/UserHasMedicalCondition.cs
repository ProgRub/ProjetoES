namespace ComponentsLibrary.Entities
{
    public class UserHasMedicalCondition:Item
    {
        public User User { get; set; }
        public BodyPart BodyPart { get; set; }
    }
}