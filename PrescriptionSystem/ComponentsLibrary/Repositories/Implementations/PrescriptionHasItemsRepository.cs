using ComponentsLibrary.Entities;

namespace ComponentsLibrary.Repositories.Implementations
{
    public class PrescriptionHasItemsRepository : BaseRepository<PrescriptionHasPrescriptionItems>
    {
        public PrescriptionHasItemsRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}