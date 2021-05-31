namespace ComponentsLibrary.Entities
{
    public class PrescriptionHasViewers : Item
    {
        public Prescription Prescription { get; set; }
        public HealthCareProfessional HealthCareProfessional { get; set; }
    }
}