using ComponentsLibrary.Entities.PrescriptionItems;

namespace ComponentsLibrary
{
    public class TreatmentRepository:BaseRepository<Treatment>
    {
        public TreatmentRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}