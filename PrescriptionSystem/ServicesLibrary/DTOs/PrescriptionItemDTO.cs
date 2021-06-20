using ComponentsLibrary.Entities.PrescriptionItems;
using ServicesLibrary.DifferentServices;

namespace ServicesLibrary.DTOs
{
    public class PrescriptionItemDTO : ItemDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public static PrescriptionItemDTO ConvertPrescriptionItemToDTO(PrescriptionItem prescriptionItem)
        {
            if (PrescriptionItemService.Instance.IsExercise(prescriptionItem.Id))
            {
                return ExerciseDTO.ConvertExerciseToDTO((Exercise) prescriptionItem);
            }
            if (PrescriptionItemService.Instance.IsMedicine(prescriptionItem.Id))
            {
                return MedicineDTO.ConvertMedicineToDTO((Medicine) prescriptionItem);
            }
            return TreatmentDTO.ConvertTreatmentToDTO((Treatment) prescriptionItem);
        }
    }
}