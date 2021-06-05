using ComponentsLibrary.Entities.PrescriptionItems;

namespace ComponentsLibrary.Entities
{
    public class TherapySessionHasTreatments
    {

        public bool Zombie { get; set; }

        public byte[] TimeStamp { get; set; }
        public int TherapySessionId { get; set; }
        public TherapySession TherapySession { get; set; }
        public int TreatmentId { get; set; }
        public Treatment Treatment { get; set; }
        public bool CompletedTreatment { get; set; }
        public string Note { get; set; }
    }
}