using ComponentsLibrary.Entities.PrescriptionItems;

namespace ComponentsLibrary.Repositories
{
    public class TreatmentRepository:BaseRepository<Treatment>
    {
        public TreatmentRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}