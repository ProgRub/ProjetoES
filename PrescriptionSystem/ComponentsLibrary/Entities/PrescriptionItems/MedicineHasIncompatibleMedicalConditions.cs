namespace ComponentsLibrary.Entities.PrescriptionItems
{
    public class MedicineHasIncompatibleMedicalConditions : Item
    {
        public MedicalCondition MedicalCondition { get; set; }
        public Medicine Medicine { get; set; }
    }
}