using ComponentsLibrary.Entities;

namespace ComponentsLibrary.Repositories
{
    internal class PrescriptionHasItemsRepository : BaseRepository<PrescriptionHasPrescriptionItems>
    {
        public PrescriptionHasItemsRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}