namespace ComponentsLibrary.Entities.PrescriptionItems
{
    public class MedicineHasIncompatibleMedicalConditions
    {

        public bool Zombie { get; set; }

        public byte[] TimeStamp { get; set; }
        public int MedicalConditionId { get; set; }
        public MedicalCondition MedicalCondition { get; set; }
        public int MedicineId { get; set; }
        public Medicine Medicine { get; set; }
    }
}