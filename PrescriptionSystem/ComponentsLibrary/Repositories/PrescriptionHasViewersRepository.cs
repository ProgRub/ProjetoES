using ComponentsLibrary.Entities;

namespace ComponentsLibrary.Repositories
{
    internal class PrescriptionHasViewersRepository:BaseRepository<PrescriptionHasViewers>
    {
        public PrescriptionHasViewersRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}