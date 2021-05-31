using ComponentsLibrary.Entities;

namespace ComponentsLibrary
{
    public class PacientRepository:BaseRepository<Patient>
    {
        public PacientRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}