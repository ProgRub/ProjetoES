using ComponentsLibrary.Entities;

namespace ComponentsLibrary.Repositories.Implementations
{
    internal class PrescriptionHasItemsRepository : BaseRepository<PrescriptionHasPrescriptionItems>
    {
        public PrescriptionHasItemsRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}