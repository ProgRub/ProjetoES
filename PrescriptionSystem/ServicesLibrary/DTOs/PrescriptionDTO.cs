using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using ServicesLibrary.DifferentServices;

namespace ServicesLibrary.DTOs
{
    public class PrescriptionDTO : ItemDTO
    {
        public HealthCareProfessionalDTO Author { get; set; }
        public PatientDTO Patient { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public IEnumerable<ExerciseDTO> Exercises { get; set; }
        public IEnumerable<TreatmentDTO> Treatments { get; set; }
        public IEnumerable<MedicineDTO> Medicines { get; set; }
        public IEnumerable<HealthCareProfessionalDTO> Viewers { get; set; }

        public static PrescriptionDTO ConvertPrescriptionToDTO(Prescription prescription)
        {
            var prescriptionDTO = new PrescriptionDTO
            {
                Id = prescription.Id,
                Patient = PatientDTO.ConvertPatientToDTO((Patient) UserService.Instance.GetUserById(prescription.Id)),
                Author = HealthCareProfessionalDTO.ConvertHealthCareProfessionalToDTO(
                    (HealthCareProfessional) UserService.Instance.GetUserById(prescription.AuthorId)),
                Description = prescription.Description,
                StartDate = prescription.StartDate,
                EndDate = prescription.EndDate
            };
            AddPrescriptionItemsToDTO(prescriptionDTO,
                PrescriptionService.Instance.GetPrescriptionItemsOfPrescriptionById(prescriptionDTO.Id));

            prescriptionDTO.Viewers = PrescriptionService.Instance
                .GetPrescriptionViewersByPrescriptionId(prescriptionDTO.Id).Select(healthCareProfessional =>
                    HealthCareProfessionalDTO.ConvertHealthCareProfessionalToDTO(healthCareProfessional)).ToList();
            return prescriptionDTO;
        }

        public static void AddPrescriptionItemsToDTO(PrescriptionDTO prescriptionDto,
            IEnumerable<PrescriptionItem> prescriptionItems)
        {
            var medicineDtos = new List<MedicineDTO>();
            var treatmentDtos = new List<TreatmentDTO>();
            var exerciseDtos = new List<ExerciseDTO>();
            foreach (var prescriptionItem in prescriptionItems)
            {
                if (PrescriptionItemService.Instance.IsExercise(prescriptionItem.Id))
                {
                    exerciseDtos.Add(ExerciseDTO.ConvertExerciseToDTO((Exercise) prescriptionItem));
                }
                else if (PrescriptionItemService.Instance.IsMedicine(prescriptionItem.Id))
                {
                    medicineDtos.Add(MedicineDTO.ConvertMedicineToDTO((Medicine) prescriptionItem));
                }
                else
                {
                    treatmentDtos.Add(TreatmentDTO.ConvertTreatmentToDTO((Treatment) prescriptionItem));
                }
            }

            prescriptionDto.Exercises = exerciseDtos;
            prescriptionDto.Medicines = medicineDtos;
            prescriptionDto.Treatments = treatmentDtos;
        }
    }
}