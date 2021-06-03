using ComponentsLibrary;
using ComponentsLibrary.Repositories.Implementations;
using ComponentsLibrary.Repositories.Interfaces;

namespace ServicesLibrary.DifferentServices
{
    public class MedicalConditionService
    {

        private IMedicalConditionRepository _prescriptionRepository;

        public MedicalConditionService()
        {
            _prescriptionRepository = new MedicalConditionRepository(Database.GetContext());
        }
    }
}