using System;
using System.Collections.Generic;
using System.Linq;
using ComponentsLibrary;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Repositories.Implementations;
using ComponentsLibrary.Repositories.Interfaces;

namespace ServicesLibrary.DifferentServices
{
    public class MedicalConditionService
    {
        #region Constants

        public const int Allergy = 0, Disease = 1;

        #endregion

        private readonly IMedicalConditionRepository _medicalConditionRepository;

        private MedicalConditionService()
        {
            _medicalConditionRepository = new MedicalConditionRepository(Database.GetContext());
        }

        internal static MedicalConditionService Instance { get; } = new MedicalConditionService();

        internal MedicalCondition GetMedicalConditionById(int id)
        {
            return _medicalConditionRepository.GetById(id);
        }

        internal IEnumerable<MedicalCondition> GetAllergies()
        {
            return _medicalConditionRepository.Find(e => e.Type == Allergy);
        }

        internal IEnumerable<MedicalCondition> GetDiseases()
        {
            return _medicalConditionRepository.Find(e => e.Type == Disease);
        }
    }
}