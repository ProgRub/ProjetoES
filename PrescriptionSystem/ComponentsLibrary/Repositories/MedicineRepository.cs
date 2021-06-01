using ComponentsLibrary.Entities.PrescriptionItems;

namespace ComponentsLibrary.Repositories
{
    public class MedicineRepository:BaseRepository<Medicine>
    {
        private MedicineHasIncompatibilityRepository _medicineHasIncompatibilityRepository;
        public MedicineRepository(PrescriptionSystemDbContext context) : base(context)
        {
            _medicineHasIncompatibilityRepository = new MedicineHasIncompatibilityRepository(context);
        }
    }
}