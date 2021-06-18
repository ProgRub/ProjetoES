using System.Collections.Generic;

namespace ServicesLibrary.DTOs
{
    public class MedicineDTO:PrescriptionItemDTO
    {
        public double Price { get; set; }
        public IEnumerable<MedicalConditionDTO> IncompatibleMedicalConditions { get; set; }
    }
}