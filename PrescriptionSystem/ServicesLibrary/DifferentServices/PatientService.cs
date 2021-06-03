using ComponentsLibrary;
using ComponentsLibrary.Repositories;
using ComponentsLibrary.Repositories.Implementations;
using ComponentsLibrary.Repositories.Interfaces;

namespace ServicesLibrary.DifferentServices
{
    public class PatientService
    {
        private IPatientRepository _patientRepository;

        public PatientService()
        {
            _patientRepository = new PatientRepository(Database.GetContext());
        }

    }
}