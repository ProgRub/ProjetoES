using System;
using System.Collections.Generic;
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

        public int RegisterPatient(string name, DateTime dateOfBirth, int phoneNumber, int healthUserNumber, string email, string password, IEnumerable<string> allergies, IEnumerable<string> diseases)
        {
            return Services.Ok;
        }
    }
}