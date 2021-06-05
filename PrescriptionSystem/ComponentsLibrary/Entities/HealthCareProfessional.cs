using System.Collections.Generic;

namespace ComponentsLibrary.Entities
{
    public abstract class HealthCareProfessional:User
    {
        public ICollection<PrescriptionHasViewers> PrescriptionHasViewersCollection { get; set; }
    }
}