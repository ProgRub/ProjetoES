﻿using System;
using System.Collections;
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

        private IMedicalConditionRepository _medicalConditionRepository;

        public MedicalConditionService()
        {
            _medicalConditionRepository = new MedicalConditionRepository(Database.GetContext());
        }

        public MedicalCondition GetMedicalConditionByName(string name)
        {
            try
            {
                return _medicalConditionRepository.Find(e => e.Name == name).First();
            }
            catch (ArgumentNullException e)
            {
                return null;
            }
        }

        public IEnumerable<MedicalCondition> GetAllergies()
        {
            return _medicalConditionRepository.Find(e => e.Type == Allergy);
        }

        public IEnumerable<MedicalCondition> GetDiseases()
        {

            return _medicalConditionRepository.Find(e => e.Type == Disease);
        }
    }
}