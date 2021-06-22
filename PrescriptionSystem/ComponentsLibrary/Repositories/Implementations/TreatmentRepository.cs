using ComponentsLibrary.Entities.PrescriptionItems;
using ComponentsLibrary.Repositories.Interfaces;

namespace ComponentsLibrary.Repositories.Implementations
{
    public class TreatmentRepository:BaseRepository<Treatment>, ITreatmentRepository
    {
        public TreatmentRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }

    }
}