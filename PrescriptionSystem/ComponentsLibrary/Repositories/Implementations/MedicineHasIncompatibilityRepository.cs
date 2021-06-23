using ComponentsLibrary.Entities.PrescriptionItems;

namespace ComponentsLibrary.Repositories.Implementations
{
    internal class MedicineHasIncompatibilityRepository : BaseRepository<MedicineHasIncompatibleMedicalConditions>
    {
        public MedicineHasIncompatibilityRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}