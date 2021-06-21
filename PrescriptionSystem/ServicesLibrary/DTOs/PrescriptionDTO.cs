using System;
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
        public IDictionary<PrescriptionItemDTO,IEnumerable<TimeSpan>> PrescriptionItemsRecommendedTimes { get; set; }
        public IEnumerable<HealthCareProfessionalDTO> Viewers { get; set; }

        public static PrescriptionDTO ConvertPrescriptionToDTO(Prescription prescription)
        {
            var prescriptionDTO = new PrescriptionDTO
            {
                Id = prescription.Id,
                Patient = PatientDTO.ConvertPatientToDTO((Patient) UserService.Instance.GetUserById(prescription.PatientId)),
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
            var recommendedTimes = new Dictionary<PrescriptionItemDTO, IEnumerable<TimeSpan>>();
            foreach (var prescriptionItem in prescriptionItems)
            {
                if (PrescriptionItemService.Instance.IsExercise(prescriptionItem.Id))
                {
                    var exerciseDto = ExerciseDTO.ConvertExerciseToDTO((Exercise) prescriptionItem);
                    exerciseDtos.Add(exerciseDto);
                    recommendedTimes.Add(exerciseDto, PrescriptionService.Instance.GetPrescriptionItemRecommendedTimesByPrescriptionIdAndItemId(prescriptionDto.Id, prescriptionItem.Id));
                }
                else if (PrescriptionItemService.Instance.IsMedicine(prescriptionItem.Id))
                {
                    var medicineDto = MedicineDTO.ConvertMedicineToDTO((Medicine) prescriptionItem);
                    medicineDtos.Add(medicineDto);
                    recommendedTimes.Add(medicineDto, PrescriptionService.Instance.GetPrescriptionItemRecommendedTimesByPrescriptionIdAndItemId(prescriptionDto.Id, prescriptionItem.Id));
                }
                else
                {
                    var treatmentDto = TreatmentDTO.ConvertTreatmentToDTO((Treatment) prescriptionItem);
                    treatmentDtos.Add(treatmentDto);
                    recommendedTimes.Add(treatmentDto, PrescriptionService.Instance.GetPrescriptionItemRecommendedTimesByPrescriptionIdAndItemId(prescriptionDto.Id, prescriptionItem.Id));
                }
            }

            prescriptionDto.Exercises = exerciseDtos;
            prescriptionDto.Medicines = medicineDtos;
            prescriptionDto.Treatments = treatmentDtos;
            prescriptionDto.PrescriptionItemsRecommendedTimes = recommendedTimes;
        }
    }
}