using ComponentsLibrary.Entities.PrescriptionItems;

namespace ComponentsLibrary.Entities
{
    public class TherapySessionHasTreatments : Item
    {
        public TherapySession TherapySession { get; set; }
        public Treatment Treatment { get; set; }
        public bool CompletedTreatment { get; set; }
        public string Note { get; set; }
    }
}