using ComponentsLibrary.Entities;

namespace ComponentsLibrary.Repositories.Implementations
{
    internal class PrescriptionHasViewersRepository : BaseRepository<PrescriptionHasViewers>
    {
        public PrescriptionHasViewersRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}