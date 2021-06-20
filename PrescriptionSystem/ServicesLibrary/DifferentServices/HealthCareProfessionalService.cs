using System.Collections.Generic;
using ComponentsLibrary;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Repositories.Implementations;
using ComponentsLibrary.Repositories.Interfaces;

namespace ServicesLibrary.DifferentServices
{
    public class HealthCareProfessionalService:UserService
    {
        private IHealthCareProfessionalRepository _healthCareProfessionalRepository;

        private HealthCareProfessionalService()
        {
            _healthCareProfessionalRepository = new HealthCareProfessionalRepository(Database.GetContext());
        }

        internal new static HealthCareProfessionalService Instance { get; } = new HealthCareProfessionalService();

        internal IEnumerable<HealthCareProfessional> GetAll()
        {
            return _healthCareProfessionalRepository.GetAll();
        }

        public HealthCareProfessional GetById(int professionalId)
        {
            return _healthCareProfessionalRepository.GetById(professionalId);
        }
    }
}