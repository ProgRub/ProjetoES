using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using ComponentsLibrary;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using ComponentsLibrary.Repositories.Implementations;
using ComponentsLibrary.Repositories.Interfaces;
using ServicesLibrary.DTOs;

namespace ServicesLibrary.DifferentServices
{
    public class PrescriptionService
    {
        private IPrescriptionRepository _prescriptionRepository;

        private PrescriptionService()
        {
            _prescriptionRepository = new PrescriptionRepository(Database.GetContext());
        }

        internal static PrescriptionService Instance { get; } = new PrescriptionService();

        internal List<Prescription> SelectedPrescriptions { get; set; }



        public void CreatePrescription(PrescriptionDTO prescriptionDTO)
        {
            var prescription = new Prescription
            {
                AuthorId = prescriptionDTO.Author.Id, PatientId = prescriptionDTO.Patient.Id,
                Description = prescriptionDTO.Description, StartDate = prescriptionDTO.StartDate.Date,
                EndDate = prescriptionDTO.EndDate.Date
            };
            _prescriptionRepository.Add(prescription);
            foreach (var prescriptionItem in prescriptionDTO.PrescriptionItemsRecommendedTimes.Keys)
            {
                _prescriptionRepository.AddPrescriptionItemToPrescription(prescription,
                    PrescriptionItemService.Instance.GetPrescriptionItemById(prescriptionItem.Id),
                    prescriptionDTO.PrescriptionItemsRecommendedTimes[prescriptionItem].ToList());
            }

            _prescriptionRepository.SaveChanges();
        }

        public IEnumerable<Prescription> GetPrescriptionsOfPatientById(int patientId)
        {
            return _prescriptionRepository.Find(e => e.PatientId == patientId);
        }

        public IEnumerable<Prescription> GetPrescriptionsStartedBeforeDate(IEnumerable<Prescription> prescriptions,
            DateTime date)
        {
            return prescriptions.Where(e => e.StartDate <= date&& e.EndDate>=date);
        }

        public void AddSelectedPrescriptionById(int id)
        {
            SelectedPrescriptions.Add(_prescriptionRepository.GetById(id));
        }

        public void AddHealthCareProfessionalAsViewerToPrescription(Prescription prescription,
            HealthCareProfessional healthCareProfessional)
        {
            if (prescription.AuthorId == healthCareProfessional.Id) return;
            _prescriptionRepository.AddViewerToPrescription(prescription, healthCareProfessional);
            _prescriptionRepository.SaveChanges();
        }

        public bool CanHealthCareProfessionalViewPrescription(Prescription prescription,
            HealthCareProfessional healthCareProfessional)
        {
            return _prescriptionRepository.IsHealthCareProfessionalPrescriptionViewer(prescription,
                healthCareProfessional);
        }

        internal IEnumerable<PrescriptionHasPrescriptionItems> GetPrescriptionHasItemsEnumerableByPrescriptionId(
            int prescriptionId)
        {
            return _prescriptionRepository.GetPrescriptionHasPrescriptionItemsEnumerable(prescriptionId);
        }

        internal IEnumerable<PrescriptionItem> GetPrescriptionItemsOfPrescriptionById(int prescriptionId)
        {
            var prescriptionItems = new List<PrescriptionItem>();
            foreach (var prescriptionHasItems in _prescriptionRepository.GetPrescriptionHasPrescriptionItemsEnumerable(
                prescriptionId))
            {
                if (PrescriptionItemService.Instance.IsExercise(prescriptionHasItems.PrescriptionItemId))
                {
                    prescriptionItems.Add(
                        PrescriptionItemService.Instance.GetExerciseById(prescriptionHasItems.PrescriptionItemId));
                }
                else if (PrescriptionItemService.Instance.IsMedicine(prescriptionHasItems.PrescriptionItemId))
                {
                    prescriptionItems.Add(
                        PrescriptionItemService.Instance.GetMedicineById(prescriptionHasItems.PrescriptionItemId));
                }
                else
                {
                    prescriptionItems.Add(
                        PrescriptionItemService.Instance.GetTreatmentById(prescriptionHasItems.PrescriptionItemId));
                }
            }

            return prescriptionItems;
        }

        public IEnumerable<HealthCareProfessional> GetPrescriptionViewersByPrescriptionId(int id)
        {
            return _prescriptionRepository.GetPrescriptionViewersByPrescriptionId(id);
        }

        public Prescription GetPrescriptionById(int prescriptionId)
        {
            return _prescriptionRepository.GetById(prescriptionId);
        }

        public IEnumerable<TimeSpan> GetPrescriptionItemRecommendedTimesByPrescriptionIdAndItemId(int prescriptionID,
            int prescriptionItemId)
        {
            return _prescriptionRepository.GetPrescriptionHasPrescriptionItemsEnumerable(prescriptionID)
                .First(e => e.PrescriptionItemId == prescriptionItemId).RecommendedTimes;
        }
    }
}