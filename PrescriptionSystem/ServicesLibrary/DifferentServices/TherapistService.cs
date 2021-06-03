using ComponentsLibrary;
using ComponentsLibrary.Repositories;
using ComponentsLibrary.Repositories.Implementations;
using ComponentsLibrary.Repositories.Interfaces;

namespace ServicesLibrary.DifferentServices
{
    public class TherapistService
    {
        private ITherapistRepository _therapistRepository;

        public TherapistService()
        {
            _therapistRepository = new TherapistRepository(Database.GetContext());
        }

    }
}