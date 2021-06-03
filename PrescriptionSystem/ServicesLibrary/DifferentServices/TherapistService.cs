using System;
using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<int> CheckTherapistRegistration( DateTime dateOfBirth, int healthUserNumber, string email)
        {
            IEnumerable<int> errorCodes = new List<int>();
            errorCodes.Append(Services.Ok);
            return errorCodes;
        }

        public void RegisterTherapist(string name, DateTime dateOfBirth, int phoneNumber, int healthUserNumber, string email, string password, IEnumerable<string> allergies, IEnumerable<string> diseases)
        {
            throw new NotImplementedException();
        }
    }
}