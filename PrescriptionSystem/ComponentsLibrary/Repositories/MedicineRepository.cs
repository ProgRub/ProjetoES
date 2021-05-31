using ComponentsLibrary.Entities.PrescriptionItems;

namespace ComponentsLibrary
{
    public class MedicineRepository:BaseRepository<Medicine>
    {
        public MedicineRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}