namespace ComponentsLibrary.Entities
{
    public class UserHasMedicalCondition
    {

        public bool Zombie { get; set; }

        public byte[] TimeStamp { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int MedicalConditionId { get; set; }
        public MedicalCondition MedicalCondition { get; set; }
    }
}