using System;
using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<int> CheckPatientRegistration( int healthUserNumber, string email)
        {
            IEnumerable<int> errorCodes = new List<int>();
            errorCodes.Append(Services.Ok);
            return errorCodes;
        }

        public void RegisterPatient(string name, DateTime dateOfBirth, int phoneNumber, int healthUserNumber, string email, string password, IEnumerable<string> allergies, IEnumerable<string> diseases)
        {
            throw new NotImplementedException();
        }
    }
}