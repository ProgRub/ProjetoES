using System.Collections.Generic;
using System.Linq;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using ServicesLibrary.DifferentServices;

namespace ServicesLibrary.DTOs
{
    public class MedicineDTO : PrescriptionItemDTO
    {
        public double Price { get; set; }
        public IEnumerable<MedicalConditionDTO> IncompatibleAllergies { get; set; }
        public IEnumerable<MedicalConditionDTO> IncompatibleDiseases { get; set; }

        public static MedicineDTO ConvertMedicineToDTO(Medicine medicine)
        {
            var medicineDTO = new MedicineDTO
                { Id = medicine.Id,Name = medicine.Name, Description = medicine.Description, Price = medicine.Price};
            var medicalConditions = PrescriptionItemService.Instance
                .GetMedicineIncompatibleMedicalConditionsIds(
                    PrescriptionItemService.Instance.GetMedicineIncompatibleMedicalConditions(medicineDTO.Id))
                .Select(medicalConditionId =>
                    MedicalConditionService.Instance.GetMedicalConditionById(medicalConditionId)).ToList();
            var medicalConditionDTOs = medicalConditions.Select(medicalCondition =>
                MedicalConditionDTO.ConvertMedicalConditionToDTO(medicalCondition)).ToList();
            medicineDTO.IncompatibleAllergies = medicalConditionDTOs.FindAll(e=>e.Type==MedicalConditionDTO.Allergy);
            medicineDTO.IncompatibleDiseases = medicalConditionDTOs.FindAll(e => e.Type == MedicalConditionDTO.Disease);
            return medicineDTO;
        }
    }
}