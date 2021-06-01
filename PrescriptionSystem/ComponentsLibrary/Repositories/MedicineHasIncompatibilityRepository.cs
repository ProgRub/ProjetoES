using ComponentsLibrary.Entities.PrescriptionItems;

namespace ComponentsLibrary.Repositories
{
    internal class MedicineHasIncompatibilityRepository:BaseRepository<MedicineHasIncompatibleMedicalConditions>
    {
        public MedicineHasIncompatibilityRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}