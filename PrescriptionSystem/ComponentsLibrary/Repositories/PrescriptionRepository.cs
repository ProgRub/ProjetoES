using ComponentsLibrary.Entities;

namespace ComponentsLibrary
{
    public class PrescriptionRepository : BaseRepository<Prescription>
    {
        public PrescriptionRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}