using ComponentsLibrary.Entities.PrescriptionItems;
using System.Collections.Generic;

namespace ComponentsLibrary.Repositories.Implementations
{
    internal class MedicineHasIncompatibilityRepository:BaseRepository<MedicineHasIncompatibleMedicalConditions>
    {
        public MedicineHasIncompatibilityRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }

    }
}