namespace ComponentsLibrary.Entities
{
    public class PrescriptionHasViewers
    {

        public bool Zombie { get; set; }

        public byte[] TimeStamp { get; set; }
        public int PrescriptionId { get; set; }
        public Prescription Prescription { get; set; }
        public int HealthCareProfessionalId { get; set; }
        public HealthCareProfessional HealthCareProfessional { get; set; }
    }
}