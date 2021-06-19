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
        public IEnumerable<MedicalConditionDTO> IncompatibleMedicalConditions { get; set; }

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
            medicineDTO.IncompatibleMedicalConditions = medicalConditionDTOs;
            return medicineDTO;
        }
    }
}