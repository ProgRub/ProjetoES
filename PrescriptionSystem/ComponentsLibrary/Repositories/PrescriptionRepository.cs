using ComponentsLibrary.Entities;

namespace ComponentsLibrary.Repositories
{
    public class PrescriptionRepository : BaseRepository<Prescription>
    {
        private PrescriptionHasItemsRepository _prescriptionHasItemsRepository;
        private PrescriptionHasViewersRepository _prescriptionHasViewersRepository;
        public PrescriptionRepository(PrescriptionSystemDbContext context) : base(context)
        {
            _prescriptionHasItemsRepository = new PrescriptionHasItemsRepository(context);
            _prescriptionHasViewersRepository = new PrescriptionHasViewersRepository(context);
        }
    }
}