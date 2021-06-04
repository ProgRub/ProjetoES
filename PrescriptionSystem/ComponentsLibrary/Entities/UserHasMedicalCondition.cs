namespace ComponentsLibrary.Entities
{
    public class UserHasMedicalCondition:Item
    {
        public User User { get; set; }
        public MedicalCondition MedicalCondition { get; set; }
    }
}