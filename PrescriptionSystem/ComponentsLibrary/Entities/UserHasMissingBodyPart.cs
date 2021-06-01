namespace ComponentsLibrary.Entities
{
    public class UserHasMissingBodyPart : Item
    {
        public User User { get; set; }
        public BodyPart BodyPart { get; set; }
    }
}