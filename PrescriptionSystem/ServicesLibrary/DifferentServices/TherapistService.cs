using System;
using System.Collections.Generic;
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

        public int RegisterTherapist(string name, DateTime dateOfBirth, int phoneNumber, int healthUserNumber, string email, string password, IEnumerable<string> allergies, IEnumerable<string> diseases)
        {
            return Services.Ok;
        }
    }
}